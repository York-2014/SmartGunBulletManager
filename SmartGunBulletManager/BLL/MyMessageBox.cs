using SmartGunBulletManager.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.BLL
{
    public class MyMessageBox
    {
        public static readonly IMyMessageBox mymessagebox = new DAL.MyMessageBox();
    }
}
