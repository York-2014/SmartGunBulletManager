using System;

namespace SmartGunBulletManager.UI.UserControls
{
    public partial class MainFrame : BasePanel
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        public void UpdateDateTime()
        {
            this.label_DateTime.Text = string.Format("当前时间：{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
