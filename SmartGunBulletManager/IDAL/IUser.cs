using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.IDAL
{
    public interface IUser
    {
        bool CheckLogin(string user, string pwd);
    }
}
