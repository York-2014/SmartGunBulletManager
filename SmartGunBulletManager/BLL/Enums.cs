using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.BLL
{
    public class Enums
    {
        #region 枚举
        public enum PowerStatusType
        {
            Normal = 0,
            Battery = 1
        }

        public enum NetworkStatusType
        {
            Connected = 0,
            Disconnect = 1
        }

        public enum ServerStatusType
        {
            Online = 0,
            Offline = 1
        }
        #endregion
    }
}
