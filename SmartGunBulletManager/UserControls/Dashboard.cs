using System;
using System.Windows.Forms;
using System.Threading;
using SmartGunBulletManager.BLL;

namespace SmartGunBulletManager.UserControls
{
    public partial class Dashboard : BasePanel
    {
        LockController lockControl = null;

        public Dashboard()
        {
            InitializeComponent();
            Init();
        }

        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            lockControl = new LockController();
            lockControl.Init("COM3", 9600);
        }
        #endregion

        #region 控件事件
        private void blockButton_GetGun_Click(object sender, EventArgs e)
        {
            try
            {
                lockControl.SendOpenLockCommand(1);
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
            lockControl.SendOpenLockCommand(2);
            Thread.Sleep(100);
            lockControl.SendOpenLockCommand(3);
            Thread.Sleep(100);
            lockControl.SendOpenLockCommand(4);
        }
        #endregion
    }
}