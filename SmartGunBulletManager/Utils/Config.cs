using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGunBulletManager.Utils
{
    public class Config
    {
        public static string SettingsXmlPath = string.Empty;
        public static string LogPath = string.Empty;
        public static string DatabaseFile = string.Empty;
        public static string DataSource
        {
            get
            {
                return string.Format("data source={0}", DatabaseFile);
            }
        }
    }
}
