using SmartGunBulletManager.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.DAL
{
    public class AppSettings : IAppSettings
    {
        public T LoadConfig<T>(string strConfigName)
        {
            T result = default(T);
            result = (T)Utils.Common.ConvertToT<T>(Utils.XmlHelper.Read(Utils.Config.SettingsXmlPath, "/configuration/" + strConfigName, "value"), default(T));
            return result;
        }
    }
}