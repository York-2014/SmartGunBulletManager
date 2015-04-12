using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartGunBulletManager.IDAL
{
    public interface IMessageBoxHelper
    {
        DialogResult ShowInfoMsg(string message);
        DialogResult ShowInfoMsg(string message, string title);

        DialogResult ShowWarningMsg(string message);
        DialogResult ShowWarningMsg(string message, string title);

        DialogResult ShowErrorMsg(string message);
        DialogResult ShowErrorMsg(string message, MessageBoxButtons buttons);
        DialogResult ShowErrorMsg(string message, string title);
        DialogResult ShowErrorMsg(string message, string title, MessageBoxButtons buttons);

        DialogResult ShowExceptionMsg(string message);
        DialogResult ShowExceptionMsg(string message, string title);
    }
}