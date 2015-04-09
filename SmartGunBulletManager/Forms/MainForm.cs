using System;
using System.Windows.Forms;

namespace SmartGunBulletManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); //双缓冲
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            LoadAppConfig();
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
        }

        public bool CheckLogin(string user, string pwd, ref string strMessage)
        {
            bool result = false;
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd))
            {
                strMessage = "用户名或密码不能为空！";
            }
            else
            {
                if (BLL.User.dbuser.CheckLogin(user, pwd))
                {
                    result = true;
                    strMessage = string.Format("用户名：{0}\r\n密码：{1}", user, pwd);
                    loginControl1.Hide();
                    main1.Show();
                }
                else
                {
                    strMessage = string.Format("用户名或密码错误！", user, pwd);
                }
            }
            return result;
        }

        private void timer_UpdateUI_Tick(object sender, EventArgs e)
        {
            if (main1.Visible)
            {
                main1.UpdateDateTime();
            }
        }
    }
}