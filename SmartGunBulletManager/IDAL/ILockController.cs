using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace SmartGunBulletManager.IDAL
{
    public interface ILockController
    {
        bool Init(string strCommNumber, int baudRate);
        void CommDataReceived(Object sender, SerialDataReceivedEventArgs e);
        bool SendOpenLockCommand(int lockAddress);
    }
}
