using Newtonsoft.Json;
using P3tr0viCh.Utils;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Camera.Properties
{
    public class LocalizedCategoryAttribute : CategoryAttribute
    {
        static string Localize(string key)
        {
            return Resources.ResourceManager.GetString(key);
        }

        public LocalizedCategoryAttribute(string key) : base(Localize(key))
        {
        }
    }

    public class AppSettings : SettingsBase<AppSettings>
    {
        public string CameraUrl { get; set; } = string.Empty;
        public string CameraUser { get; set; } = string.Empty;
        [JsonIgnore]
        public string CameraPass { get; set; } = string.Empty;
        [Browsable(false)]
        public string CameraPassEncrypted
        {
            get
            {
                return Crypto.Encrypt(CameraPass, EncKey.Key);
            }
            set
            {
                try
                {
                    CameraPass = Crypto.Decrypt(value, EncKey.Key);
                }
                catch (Exception)
                {
                    Debug.WriteLine("Crypto.Decrypt fail");
                    CameraPass = string.Empty;
                }
            }
        }
    }
}