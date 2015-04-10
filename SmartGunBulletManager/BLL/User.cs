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
        public enum RoleType
        {
            Admin = 1,
            Operator = 2,
            Holder = 3
        }
        public static readonly IUser dbuser = new DAL.User(Config.DataSource);
    }
}
