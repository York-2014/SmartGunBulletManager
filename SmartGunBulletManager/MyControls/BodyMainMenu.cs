using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartGunBulletManager.MyControls
{
    public partial class BodyMainMenu : UserControl
    {
        public BodyMainMenu()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.FromArgb(120, 40, 60, 82);
        }
    }
}
