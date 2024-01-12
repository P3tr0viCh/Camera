using Camera.Properties;
using Emgu.CV;
using Emgu.CV.Cuda;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using P3tr0viCh.Utils;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera
{
    public partial class Main : Form
    {
        private VideoCapture capture;

        private int startCounter = 0;
        private int fpsCounter = 0;

        public Main()
        {
            InitializeComponent();

            AppSettings.Directory = Files.ExecutableDirectory();

            Debug.WriteLine("Settings: " + AppSettings.FilePath);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            slText.Text = string.Empty;
            slFPS.Text = string.Empty;
            slCounter.Text = string.Empty;

            (tboxPass.Control as TextBox).PasswordChar = '*';

            AppSettings.Default.Load();

            tboxUrl.Text = AppSettings.Default.CameraUrl;
            tboxUser.Text = AppSettings.Default.CameraUser;
            tboxPass.Text = AppSettings.Default.CameraPass;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();

            AppSettings.Default.CameraUrl = tboxUrl.Text;
            AppSettings.Default.CameraUser = tboxUser.Text;
            AppSettings.Default.CameraPass = tboxPass.Text;

            AppSettings.Default.Save();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            Start();
        }

        private string GetCameraUri()
        {
            if (string.IsNullOrWhiteSpace(tboxUrl.Text))
            {
                throw new Exception("url empty");
            }

            var uri = new UriBuilder(tboxUrl.Text);

            if (!string.IsNullOrWhiteSpace(tboxUser.Text))
            {
                uri.UserName = tboxUser.Text;
            }

            if (!string.IsNullOrWhiteSpace(tboxPass.Text))
            {
                uri.Password = tboxPass.Text;
            }

            return uri.ToString();
        }

        private VideoCapture GetVideoCapture()
        {
            var capture = new VideoCapture(GetCameraUri(), VideoCapture.API.Ffmpeg, Tuple.Create(CapProp.OpenTimeoutMsec, 10000));

            if (!capture.IsOpened)
            {
                Invoke((MethodInvoker)delegate
                {
                    Stop();
                });

                throw new Exception("error open camera");
            }

            return capture;
        }

        private void Start()
        {
            Stop();

            Task.Run(() =>
            {
                try
                {
                    slText.Text = "camera openning...";

                    capture = GetVideoCapture();

                    capture.ImageGrabbed += Capture_ImageGrabbed;

                    startCounter++;

                    fpsCounter = 0;

                    slCounter.Text = startCounter.ToString();

                    capture.Start();

                    slText.Text = string.Empty;

                    Invoke((MethodInvoker)delegate
                    {
                        timerFPS.Start();
                    });
                }
                catch (Exception ex)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        Stop();

                        slText.Text = ex.Message;

                        timerRestart.Start();
                    });
                }
            });
        }

        private readonly object lockObj = new object();

        private void Capture_ImageGrabbed(object sender, EventArgs e)
        {
            slText.Text = string.Empty;

            try
            {
                lock (lockObj)
                {
                    var m = new Mat();

                    try
                    {
                        if (!capture.Retrieve(m) || m.IsEmpty)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Start();
                            });

                            return;
                        }

                        pictureBox.Image = m.ToImage<Bgr, byte>()
                            .Resize(pictureBox.Width, pictureBox.Height, Inter.Area, true).ToBitmap();
                    }
                    finally
                    {
                        m.Dispose();
                    }
                }

                fpsCounter++;
            }
            catch (Exception ex)
            {
                slText.Text = ex.Message;
            }
        }

        private void Stop()
        {
            timerFPS.Stop();

            timerRestart.Stop();

            slFPS.Text = string.Empty;
            slText.Text = string.Empty;
            slCounter.Text = string.Empty;

            if (capture == null)
            {
                return;
            }

            capture.Stop();

            capture.Dispose();
            capture = null;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Stop();

            startCounter = 0;
        }

        private void TimerFPS_Tick(object sender, EventArgs e)
        {
            slFPS.Text = fpsCounter.ToString();

            fpsCounter = 0;
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            slTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void SaveImage(string fileName)
        {
            slText.Text = "image saving...";

            try
            {
                using (var capture = GetVideoCapture())
                using (var m = capture.QueryFrame())
                {
                    if (m == null)
                    {
                        throw new Exception("error query frame");
                    }

                    using (var image = m.ToImage<Bgr, byte>().ToBitmap())
                    {
                        image.Save(fileName, ImageFormat.Jpeg);
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message);
            }

            slText.Text = string.Empty;
        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                SaveImage(Path.Combine(Files.ExecutableDirectory(), DateTime.Now.ToString("yyyy.MM.dd HH-mm-ss") + ".jpeg"));
            });
        }

        private void TimerRestart_Tick(object sender, EventArgs e)
        {
            timerRestart.Stop();

            Start();
        }
    }
}