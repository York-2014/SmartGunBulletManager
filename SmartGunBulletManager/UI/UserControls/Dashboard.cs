using System;
using System.Windows.Forms;
using System.Threading;
using SmartGunBulletManager.BLL;

namespace SmartGunBulletManager.UI.UserControls
{
    public partial class Dashboard : BasePanel
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        #region 控件事件
        private void blockButton_GetGun_Click(object sender, EventArgs e)
        {
            try
            {
               BLL.LockController.lockController.SendOpenLockCommand(1);
                MessageBox.Show("取枪成功!", "提示");
            }
            catch (Exception ex)
            {
                BLL.LogHelper.logger.Error("取枪失败!", ex);
                MessageBox.Show("取枪失败!", "提示");
            }
        }

        private void blockButton_BackGun_Click(object sender, EventArgs e)
        {
            BLL.LockController.lockController.SendOpenLockCommand(2);
            Thread.Sleep(50);
            BLL.LockController.lockController.SendOpenLockCommand(3);
            Thread.Sleep(50);
            BLL.LockController.lockController.SendOpenLockCommand(4);
        }
        #endregion

        #region 锁屏
        /// <summary>
        /// 锁屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_LockScreen_Click(object sender, EventArgs e)
        {
            GetMainForm().SwitchToMainUI(false);
        }
        #endregion

        private void blockButton_Exit_BlockClick(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBoxHelper.messageboxhelper.ShowWarningMsg("确定要退出吗？"))
            {
                Application.Exit();
            }
        }

        public void UpdateAllStatusDisplay()
        {
            label_Temperature.Text = string.Format("温度：{0} ℃", GetMainForm().Temperature);
            label_Humidity.Text = string.Format("湿度：{0} %RH", GetMainForm().Humidity);
            label_AlcoholConcentration.Text = string.Format("酒精浓度：{0} mg/100ml", GetMainForm().AlcoholConcentration);
            if (GetMainForm().PowerState == Enums.PowerStatusType.Normal)
            {
                pictureBox_PowerState.Image = global::SmartGunBulletManager.Properties.Resources.Power_Normal_32;
            }
            else
            {
                pictureBox_PowerState.Image = global::SmartGunBulletManager.Properties.Resources.Power_Battery_32;
            }

            if (GetMainForm().NetworkState == Enums.NetworkStatusType.Connected)
            {
                pictureBox_NetworkState.Image = global::SmartGunBulletManager.Properties.Resources.Network_Connected_32;
            }
            else
            {
                pictureBox_NetworkState.Image = global::SmartGunBulletManager.Properties.Resources.Network_Disconnect_32;
            }

            if (GetMainForm().ServerState == Enums.ServerStatusType.Online)
            {
                pictureBox_ServerState.Image = global::SmartGunBulletManager.Properties.Resources.Server_Online_32;
            }
            else
            {
                pictureBox_ServerState.Image = global::SmartGunBulletManager.Properties.Resources.Server_Offline_32;
            }

        }
    }
}