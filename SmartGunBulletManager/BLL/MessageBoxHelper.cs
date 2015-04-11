using SmartGunBulletManager.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.BLL
{
    public class MessageBoxHelper
    {
        public static readonly IMessageBoxHelper messageboxhelper = new DAL.MessageBoxHelper();
    }
}