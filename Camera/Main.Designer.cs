namespace Camera
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.slUrl = new System.Windows.Forms.ToolStripLabel();
            this.tboxUrl = new System.Windows.Forms.ToolStripTextBox();
            this.slUser = new System.Windows.Forms.ToolStripLabel();
            this.tboxUser = new System.Windows.Forms.ToolStripTextBox();
            this.slPass = new System.Windows.Forms.ToolStripLabel();
            this.tboxPass = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnImage = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.slTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.slCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.slFPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.slText = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerFPS = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerRestart = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slUrl,
            this.tboxUrl,
            this.slUser,
            this.tboxUser,
            this.slPass,
            this.tboxPass,
            this.toolStripSeparator1,
            this.btnOpen,
            this.btnStop,
            this.btnImage});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(721, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // slUrl
            // 
            this.slUrl.Name = "slUrl";
            this.slUrl.Size = new System.Drawing.Size(21, 22);
            this.slUrl.Text = "url";
            // 
            // tboxUrl
            // 
            this.tboxUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxUrl.Name = "tboxUrl";
            this.tboxUrl.Size = new System.Drawing.Size(220, 25);
            // 
            // slUser
            // 
            this.slUser.Name = "slUser";
            this.slUser.Size = new System.Drawing.Size(29, 22);
            this.slUser.Text = "user";
            // 
            // tboxUser
            // 
            this.tboxUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(100, 25);
            // 
            // slPass
            // 
            this.slPass.Name = "slPass";
            this.slPass.Size = new System.Drawing.Size(30, 22);
            this.slPass.Text = "pass";
            // 
            // tboxPass
            // 
            this.tboxPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxPass.Name = "tboxPass";
            this.tboxPass.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 22);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnImage
            // 
            this.btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(44, 22);
            this.btnImage.Text = "Image";
            this.btnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 25);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(721, 401);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slTime,
            this.slCounter,
            this.slFPS,
            this.slText});
            this.statusStrip.Location = new System.Drawing.Point(0, 404);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(721, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // slTime
            // 
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(31, 17);
            this.slTime.Text = "time";
            // 
            // slCounter
            // 
            this.slCounter.Name = "slCounter";
            this.slCounter.Size = new System.Drawing.Size(48, 17);
            this.slCounter.Text = "counter";
            // 
            // slFPS
            // 
            this.slFPS.Name = "slFPS";
            this.slFPS.Size = new System.Drawing.Size(23, 17);
            this.slFPS.Text = "fps";
            // 
            // slText
            // 
            this.slText.Name = "slText";
            this.slText.Size = new System.Drawing.Size(27, 17);
            this.slText.Text = "text";
            // 
            // timerFPS
            // 
            this.timerFPS.Interval = 1000;
            this.timerFPS.Tick += new System.EventHandler(this.TimerFPS_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // timerRestart
            // 
            this.timerRestart.Interval = 1000;
            this.timerRestart.Tick += new System.EventHandler(this.TimerRestart_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 426);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Camera";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripTextBox tboxUrl;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel slText;
        private System.Windows.Forms.ToolStripLabel slUrl;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripStatusLabel slCounter;
        private System.Windows.Forms.Timer timerFPS;
        private System.Windows.Forms.ToolStripStatusLabel slFPS;
        private System.Windows.Forms.ToolStripStatusLabel slTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.ToolStripLabel slUser;
        private System.Windows.Forms.ToolStripTextBox tboxUser;
        private System.Windows.Forms.ToolStripLabel slPass;
        private System.Windows.Forms.ToolStripTextBox tboxPass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnImage;
        private System.Windows.Forms.Timer timerRestart;
    }
}

