using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SmartGunBulletManager.UI.UserControls
{
    public partial class BlockButton : BasePanel
    {
        #region 私有变量
        private Color btnBackColor;
        #endregion

        #region 控件的自定义属性
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

        #region 控件的自定义事件
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler BlockClick;
        protected virtual void OnBlockClick(EventArgs e)
        {
            if (BlockClick != null)
            {
                BlockClick(this, e);
            }
        }
        #endregion

        #region 构造函数
        public BlockButton()
        {
            InitializeComponent();
        }
        #endregion

        #region 控件事件
        private void BlockButton_MouseDown(object sender, MouseEventArgs e)
        {
            btnBackColor = this.BackColor;
            this.BackColor = Color.Red;
        }

        private void BlockButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = btnBackColor;
        }

        private void BlockButton_Click(object sender, EventArgs e)
        {
            this.OnBlockClick(e);
        }
        #endregion
    }
}