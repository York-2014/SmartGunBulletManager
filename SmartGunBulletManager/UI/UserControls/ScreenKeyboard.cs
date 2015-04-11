using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SmartGunBulletManager.UI.UserControls
{
    public partial class ScreenKeyboard : BasePanel
    {
        private Point mousePoint = new Point();

        public ScreenKeyboard()
        {
            InitializeComponent();
            //this.TabStop = false;
            //this.SetStyle(ControlStyles.Selectable, false);
            //this.UpdateStyles();
        }

        private void SendKeyValue(object sender, EventArgs e)
        {
            SendKeys.Send(((KeyboardButton)sender).KeyValue);
        }

        private void keyboardButton_Backspace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void keyboardButton_Clear_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^(A)");
            SendKeys.Send("{BACKSPACE}");
        }

        private void keyboardButton_TAB_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void keyboardButton_Enter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Enter}");
            this.Hide();
        }

        public void HideBody(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePoint = e.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Left = e.X - mousePoint.X + this.Left;
                this.Top = e.Y - mousePoint.Y + this.Top;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Left > 1024 - this.Width)
            {
                this.Left = 1024 - this.Width;
            }
            if (this.Top > 768 - this.Height)
            {
                this.Top = 768 - this.Height;
            }
            if (this.Left < 0)
            {
                this.Left = 0;
            }
            if (this.Top < 0)
            {
                this.Top = 0;
            }
        }
    }
}