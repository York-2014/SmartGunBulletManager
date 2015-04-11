using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartGunBulletManager.UI.UserControls
{
    public partial class KeyboardButton : UserControl
    {
        public KeyboardButton()
        {
            InitializeComponent();
        }

        #region 控件的自定义属性
        private string _KeyValue = "1";
        [CategoryAttribute("自定义属性")]
        [DescriptionAttribute("设置控件的显示文字")]
        public string KeyValue
        {
            set
            {
                _KeyValue = value;
                label_KeyValue.Text = _KeyValue;
            }
            get { return _KeyValue; }
        }

        private Font _KeyFont = new Font("宋体", 12);
        [CategoryAttribute("自定义属性")]
        [DescriptionAttribute("设置控件的字体")]
        public Font KeyFont
        {
            set
            {
                _KeyFont = value;
                label_KeyValue.Font = _KeyFont;
            }
            get { return _KeyFont; }
        }
        #endregion

        #region 控件的自定义事件
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler KeyboardButtonClick;
        protected virtual void OnKeyboardButtonClick(EventArgs e)
        {
            if (KeyboardButtonClick != null)
            {
                KeyboardButtonClick(this, e);
            }
        }
        #endregion

        private void label_KeyValue_MouseDown(object sender, MouseEventArgs e)
        {
            this.label_KeyValue.BackColor = Color.Gray;
        }

        private void label_KeyValue_MouseUp(object sender, MouseEventArgs e)
        {
            this.label_KeyValue.BackColor = SystemColors.InactiveCaptionText;
            this.OnKeyboardButtonClick(e);
        }
    }
}
