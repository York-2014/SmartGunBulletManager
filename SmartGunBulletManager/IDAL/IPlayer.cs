using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.IDAL
{
    public interface IPlayer
    {
        void InitPlayer();
        void PlaySound(string strMp3Url);
        void LoopMode(bool isLoop);
        void Volume(int volume);
    }
}