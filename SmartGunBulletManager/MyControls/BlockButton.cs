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
    public partial class BlockButton : UserControl
    {
        #region 控件自定义属性
        //private Color _BackGroundColor = Color.White;
        //[CategoryAttribute("自定义属性")]
        //[DescriptionAttribute("设置控件的背景颜色")]
        //public Color BackGroundColor
        //{
        //    set
        //    {
        //        _BackGroundColor = value;
        //        this.BackColor = _BackGroundColor;
        //    }
        //    get { return _BackGroundColor; }
        //}

        private string _Description = "文字描述";
        [CategoryAttribute("自定义属性")]
        [DescriptionAttribute("设置控件的文字描述")]
        public string Description
        {
            set
            {
                _Description = value;
                label_Description.Text = _Description;
            }
            get { return _Description; }
        }

        private Image _Icon = null;
        [CategoryAttribute("自定义属性")]
        [DescriptionAttribute("设置控件的Icon图标")]
        public Image Icon
        {
            set
            {
                _Icon = value;
                pictureBox_Icon.Image = _Icon;
            }
            get { return _Icon; }
        }
        #endregion

        public BlockButton()
        {
            InitializeComponent();
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("当前点击：{0}",_Description), "智能枪弹柜管理系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
