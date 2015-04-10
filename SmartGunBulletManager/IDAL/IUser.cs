using SmartGunBulletManager.BLL;
using SmartGunBulletManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.IDAL
{
    public interface IUser
    {
        UserEntity CheckLoginByPwd(User.RoleType userType, string user, string pwd);
        UserEntity CheckLoginByFingerprint(User.RoleType userType, string user, object fingerprintInfo);
    }
}
