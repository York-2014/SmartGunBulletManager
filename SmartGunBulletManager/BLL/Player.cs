using SmartGunBulletManager.DAL;
using SmartGunBulletManager.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.BLL
{
    public class Player
    {
        public static readonly IPlayer player = new DAL.Player();
    }
}
