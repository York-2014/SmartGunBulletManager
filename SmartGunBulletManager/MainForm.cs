using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartGunBulletManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            timer_UpdateUI.Interval = 100;
            timer_UpdateUI.Enabled = true;
            //this.TopMost = true;
        }

        public void Login(string user, string pwd)
        {
            loginControl1.Hide();
            main1.Show();
            MessageBox.Show(pwd, user);
        }

        private void timer_UpdateUI_Tick(object sender, EventArgs e)
        {
            if (main1.Visible)
            {
                main1.UpdateDateTime();
            }
        }
    }
}