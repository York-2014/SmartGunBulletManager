using SmartGunBulletManager.BLL;
using SmartGunBulletManager.Entity;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SmartGunBulletManager.UI.Forms
{
    public partial class MainForm : BaseForm
    {
        #region 变量
        public User.RoleType currentUserType = User.RoleType.Operator;//默认值班员权限登录
        public UserEntity currentUserEntity = new UserEntity();
        #endregion

        #region 构造函数
        public MainForm()
        {
            LoadAppConfig();
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲
            this.UpdateStyles();
        }
        #endregion

        #region 加载应用配置
        /// <summary>
        /// 加载应用配置
        /// </summary>
        private void LoadAppConfig()
        {
            Utils.Config.SettingsXmlPath = "Settings.config";
            Utils.Config.LogPath = BLL.AppSettings.settings.LoadConfig<string>("loggerpath");
            Utils.Config.DatabaseFile = BLL.AppSettings.settings.LoadConfig<string>("datebasefile");
            try
            {
                //解密密码字符串
                Utils.Config.DatabasePwd = Utils.RSA.RSADecryptData(Utils.Common.Base64StringToString(BLL.AppSettings.settings.LoadConfig<String>("datebasepwd"))
                    , Utils.Common.Base64StringToString(Utils.Config.RsaPrivateKey));
            }
            catch
            {
                BLL.MessageBoxHelper.messageboxhelper.ShowErrorMsg("本地数据库密码验证失败！");
            }
            //加载状态检测频率
            Utils.Config.CheckTemperatureInterval = BLL.AppSettings.settings.LoadConfig<int>("checktemperatureinterval");
            Utils.Config.CheckHumidityInterval = BLL.AppSettings.settings.LoadConfig<int>("checkhumidityinterval");
            Utils.Config.CheckAlcoholConcentrationInterval = BLL.AppSettings.settings.LoadConfig<int>("checkalcoholconcentrationinterval");
            Utils.Config.CheckPowerStateInterval = BLL.AppSettings.settings.LoadConfig<int>("checkpowerstateinterval");
            Utils.Config.CheckNetworkStateInterval = BLL.AppSettings.settings.LoadConfig<int>("checknetworkstateinterval");
            Utils.Config.CheckServerStateInterval = BLL.AppSettings.settings.LoadConfig<int>("checkserverstateinterval");
        }
        #endregion

        #region 定时检查传感器状态
        private System.Threading.Timer checkTemperatureTimer = null;
        private System.Threading.Timer checkHumidityTimer = null;
        private System.Threading.Timer checkAlcoholConcentrationTimer = null;
        private System.Threading.Timer checkPowerStateTimer = null;
        private System.Threading.Timer checkNetworkStateTimer = null;
        private System.Threading.Timer checkServerStateTimer = null;

        private void StarCheckStatusTimers()
        {
            checkTemperatureTimer = new System.Threading.Timer(new TimerCallback(CheckTemperature), null, 0, Utils.Config.CheckTemperatureInterval);
            checkHumidityTimer = new System.Threading.Timer(new TimerCallback(CheckHumidity), null, 0, Utils.Config.CheckHumidityInterval);
            checkAlcoholConcentrationTimer = new System.Threading.Timer(new TimerCallback(CheckAlcoholConcentration), null, 0, Utils.Config.CheckAlcoholConcentrationInterval);
            checkPowerStateTimer = new System.Threading.Timer(new TimerCallback(CheckPowerState), null, 0, Utils.Config.CheckPowerStateInterval);
            checkNetworkStateTimer = new System.Threading.Timer(new TimerCallback(CheckNetworkState), null, 0, Utils.Config.CheckNetworkStateInterval);
            checkServerStateTimer = new System.Threading.Timer(new TimerCallback(CheckServerState), null, 0, Utils.Config.CheckServerStateInterval);
        }

        private void CheckTemperature(object obj)
        {
            this.CheckAndUpdateTemperature();
            checkTemperatureTimer.Change(0, Utils.Config.CheckTemperatureInterval);
        }
        private void CheckHumidity(object obj)
        {
            this.CheckAndUpdateHumidity();
            checkTemperatureTimer.Change(0, Utils.Config.CheckHumidityInterval);
        }
        private void CheckAlcoholConcentration(object obj)
        {
            this.CheckAndUpdateAlcoholConcentration();
            checkTemperatureTimer.Change(0, Utils.Config.CheckAlcoholConcentrationInterval);
        }
        private void CheckPowerState(object obj)
        {
            this.CheckAndUpdatePowerState();
            checkTemperatureTimer.Change(0, Utils.Config.CheckPowerStateInterval);
        }
        private void CheckNetworkState(object obj)
        {
            this.CheckAndUpdateNetworkState();
            checkTemperatureTimer.Change(0, Utils.Config.CheckNetworkStateInterval);
        }
        private void CheckServerState(object obj)
        {
            this.CheckAndUpdateServerState();
            checkTemperatureTimer.Change(0, Utils.Config.CheckServerStateInterval);
        }
        #endregion

        #region 初始化
        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            StarCheckStatusTimers();
            InitPlayer();
            this.TopMost = true;
        }

        private void InitPlayer()
        {
            axWindowsMediaPlayer1.settings.setMode("loop", false);
            axWindowsMediaPlayer1.settings.volume = 100;
        }
        #endregion

        #region 密码登录验证
        /// <summary>
        /// 密码登录验证
        /// </summary>
        /// <param name="userNumber">用户编号</param>
        /// <param name="pwd">密码</param>
        /// <param name="strMessage">返回消息</param>
        /// <returns></returns>
        public bool CheckLoginByPwd(string userNumber, string pwd, ref string strMessage)
        {
            bool result = false;
            UserEntity userEntity = BLL.User.dbuser.CheckLoginByPwd(currentUserType, userNumber, pwd);
            if (null != userEntity)
            {
                currentUserEntity = userEntity;
                result = true;
                strMessage = string.Format("人员编号：{0}\r\n密码：{1}", userNumber, pwd);
                SwitchToMainUI(true);
            }
            else
            {
                strMessage = string.Format("人员编号或密码错误！", userNumber, pwd);
            }
            return result;
        }
        #endregion

        #region 指纹验证登录
        /// <summary>
        /// 指纹验证登录
        /// </summary>
        /// <param name="userNumber">人员编号</param>
        /// <param name="fingerprintInfo">指纹信息</param>
        /// <param name="strMessage">返回消息</param>
        /// <returns></returns>
        public bool CheckLoginByFingerprint(string userNumber, object fingerprintInfo, ref string strMessage)
        {
            bool result = false;
            UserEntity userEntity = BLL.User.dbuser.CheckLoginByFingerprint(currentUserType, userNumber, fingerprintInfo);
            if (null != userEntity)
            {
                currentUserEntity = userEntity;
                result = true;
                strMessage = string.Format("人员编号：{0}\r\n指纹验证成功！", userNumber);
                SwitchToMainUI(true);
            }
            else
            {
                strMessage = string.Format("人员编号或指纹错误！", userNumber);
            }
            return result;
        }
        #endregion

        #region 定时更新UI
        /// <summary>
        /// 定时更新UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_UpdateUI_Tick(object sender, EventArgs e)
        {
            if (mainFrame1.Visible)
            {
                mainFrame1.UpdateAllStatusDisplay();
            }
        }
        #endregion

        #region 切换到主界面
        /// <summary>
        /// 切换到主界面
        /// </summary>
        /// <param name="MainUI"></param>
        public void SwitchToMainUI(bool MainUI)
        {
            DisplayScreenKeyboard(false);
            if (MainUI)
            {
                loginControl1.Enabled = false;
                loginControl1.Hide();
                mainFrame1.Enabled = true;
                mainFrame1.Show();
                //切换到主界面执行的事件
                mainFrame1.SetCurrentUserName(currentUserEntity.fullname);
                PlaySound(Utils.Config.soundFile_PresonalizeSettings);
            }
            else
            {
                PlaySound(Utils.Config.soundFile_SelectOptions);
                mainFrame1.Enabled = false;
                mainFrame1.Hide();
                loginControl1.Enabled = true;
                loginControl1.Show();
                //切换到登录界面执行的事件
                loginControl1.Init();
            }
        }
        #endregion

        #region 显示屏幕键盘
        /// <summary>
        /// 显示屏幕键盘
        /// </summary>
        /// <param name="display"></param>
        public void DisplayScreenKeyboard(bool display)
        {
            if (display)
            {
                this.screenKeyboard1.Show();
                this.screenKeyboard1.BringToFront();
            }
            else
            {
                this.screenKeyboard1.Hide();
            }
        }
        #endregion

        #region 播放音频
        /// <summary>
        /// 播放音频
        /// </summary>
        /// <param name="strMp3Url"></param>
        public void PlaySound(string strMp3Url)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.URL = strMp3Url;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        #endregion
    }
}