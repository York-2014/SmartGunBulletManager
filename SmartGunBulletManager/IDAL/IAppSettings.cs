using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.IDAL
{
    public interface IAppSettings
    {
        T LoadConfig<T>(string strConfigName);
    }
}
