using SmartGunBulletManager.IDAL;
using System.Windows.Forms;

namespace SmartGunBulletManager.DAL
{
    public class MessageBoxHelper : IMessageBoxHelper
    {
        public DialogResult ShowInfoMsg(string message)
        {
            return MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult ShowInfoMsg(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult ShowWarningMsg(string message)
        {
            return MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public DialogResult ShowWarningMsg(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public DialogResult ShowErrorMsg(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        public DialogResult ShowErrorMsg(string message, MessageBoxButtons buttons)
        {
            return MessageBox.Show(message, "Error", buttons, MessageBoxIcon.Error);
        }

        public DialogResult ShowErrorMsg(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        public DialogResult ShowErrorMsg(string message, string title, MessageBoxButtons buttons)
        {
            return MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
        }

        public DialogResult ShowExceptionMsg(string message)
        {
            return MessageBox.Show(message, "Exception", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }

        public DialogResult ShowExceptionMsg(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }
    }
}