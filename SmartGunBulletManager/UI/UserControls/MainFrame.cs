using System;

namespace SmartGunBulletManager.UI.UserControls
{
    public partial class MainFrame : BasePanel
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        public void UpdateAllStatusDisplay()
        {
            this.label_DateTime.Text = string.Format("当前时间：{0}", GetMainForm().GetCurrentTimeString("yyyy-MM-dd HH:mm:ss"));
            this.Dashboard1.UpdateAllStatusDisplay();
        }

        public void SetCurrentUserName(string userName)
        {
            this.label_Operator.Text = string.Format("当前用户：{0}", userName);
        }
    }
}