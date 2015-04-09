using SmartGunBulletManager.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.BLL
{
    public class AppSettings
    {
        public static readonly IAppSettings settings = new DAL.AppSettings();
    }
}
