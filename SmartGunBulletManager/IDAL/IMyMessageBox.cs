using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartGunBulletManager.IDAL
{
    public interface IMyMessageBox
    {
        DialogResult Info(string message);
        DialogResult Info(string message, string title);
        DialogResult Warning(string message);
        DialogResult Warning(string message, string title);
        DialogResult Error(string message);
        DialogResult Error(string message, MessageBoxButtons buttons);
        DialogResult Error(string message, string title);
        DialogResult Error(string message, string title, MessageBoxButtons buttons);
        DialogResult Exception(string message);
        DialogResult Exception(string message, string title);
    }
}
