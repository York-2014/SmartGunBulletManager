using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.Entity
{
    public class UserEntity
    {
        public int id { get; set; }
        public int roleid { get; set; }
        public string usernumber { get; set; }
        public string fullname { get; set; }
        public string password { get; set; }
        public DateTime createtime { get; set; }
        public DateTime lastlogintime { get; set; }
        public DateTime lastmodifytime { get; set; }
    }
}