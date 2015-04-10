using SmartGunBulletManager.BLL;
using SmartGunBulletManager.Entity;
using System;
using System.Text;
using System.Windows.Forms;

namespace SmartGunBulletManager.UI.Forms
{
    public partial class MainForm : Form
    {
        public User.RoleType currentUserType = User.RoleType.Operator;//默认值班员权限登录

        public MainForm()
        {
            LoadAppConfig();
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲
            this.UpdateStyles();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            timer_UpdateUI.Interval = 100;
            timer_UpdateUI.Enabled = true;
            this.TopMost = true;
        }

        /// <summary>
        /// 加载应用配置
        /// </summary>
        private void LoadAppConfig()
        {
            Utils.Config.SettingsXmlPath = "Settings.config";
            Utils.Config.LogPath = BLL.AppSettings.settings.LoadConfig<String>("loggerpath");
            Utils.Config.DatabaseFile = BLL.AppSettings.settings.LoadConfig<String>("datebasefile");
            try
            {
                //解密密码字符串
                Utils.Config.DatabasePwd = Utils.RSA.RSADecryptData(Utils.Common.Base64StringToString(BLL.AppSettings.settings.LoadConfig<String>("datebasepwd"))
                    , Utils.Common.Base64StringToString(Utils.Config.RsaPrivateKey));
            }
            catch
            {
                BLL.MyMessageBox.mymessagebox.Error("本地数据库密码验证失败！");
            }
        }

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
                result = true;
                strMessage = string.Format("人员编号：{0}\r\n密码：{1}", userNumber, pwd);
                UnLockUI(true);
            }
            else
            {
                strMessage = string.Format("人员编号或密码错误！", userNumber, pwd);
            }
            return result;
        }

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
                result = true;
                strMessage = string.Format("人员编号：{0}\r\n指纹验证成功！", userNumber);
                UnLockUI(true);
            }
            else
            {
                strMessage = string.Format("人员编号或指纹错误！", userNumber);
            }
            return result;
        }

        private void timer_UpdateUI_Tick(object sender, EventArgs e)
        {
            if (mainFrame1.Visible)
            {
                mainFrame1.UpdateDateTime();
            }
        }

        /// <summary>
        /// 切换登录界面
        /// </summary>
        /// <param name="login"></param>
        public void UnLockUI(bool open)
        {
            if (open)
            {
                loginControl1.Enabled = false;
                loginControl1.Hide();
                mainFrame1.Enabled = true;
                mainFrame1.Show();
            }
            else
            {
                mainFrame1.Enabled = false;
                mainFrame1.Hide();
                loginControl1.Clear();
                loginControl1.Enabled = true;
                loginControl1.Show();
            }
        }
    }
}