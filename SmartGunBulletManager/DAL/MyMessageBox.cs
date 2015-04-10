using SmartGunBulletManager.IDAL;
using System.Windows.Forms;

namespace SmartGunBulletManager.DAL
{
    public class MyMessageBox : IMyMessageBox
    {
        public DialogResult Info(string message)
        {
            return MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Info(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Warning(string message)
        {
            return MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public DialogResult Warning(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public DialogResult Error(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        public DialogResult Error(string message, MessageBoxButtons buttons)
        {
            return MessageBox.Show(message, "Error", buttons, MessageBoxIcon.Error);
        }

        public DialogResult Error(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        public DialogResult Error(string message, string title, MessageBoxButtons buttons)
        {
            return MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
        }

        public DialogResult Exception(string message)
        {
            return MessageBox.Show(message, "Exception", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }

        public DialogResult Exception(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }
    }
}