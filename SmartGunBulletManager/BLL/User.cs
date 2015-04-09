using SmartGunBulletManager.IDAL;
using SmartGunBulletManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.BLL
{
    public class User
    {
        public static readonly IUser dbuser = new DAL.User(Config.DataSource);
    }
}
