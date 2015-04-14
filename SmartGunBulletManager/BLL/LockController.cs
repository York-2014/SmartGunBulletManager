using SmartGunBulletManager.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.BLL
{
    public class LockController
    {
        public static readonly ILockController lockController = new DAL.LockController();
    }
}
