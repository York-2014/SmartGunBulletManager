using System;
using System.Drawing;
using System.Windows.Forms;
using SmartGunBulletManager.UI.Forms;
using System.Threading;

namespace SmartGunBulletManager.UI.UserControls
{
    public partial class LoginControl : BasePanel
    {
        public LoginControl()
        {
            InitializeComponent();
            //Init();
        }

        private void Init()
        {
            timer_UpdateUI.Interval = 5;
            timer_UpdateUI.Enabled = true;
        }

        #region 角色类型切换
        private void label_Operator_Click(object sender, EventArgs e)
        {
            ChangeColorBySelectedRole((Label)sender);
        }

        private void label_Holder_Click(object sender, EventArgs e)
        {
            ChangeColorBySelectedRole((Label)sender);
        }

        private void label_Admin_Click(object sender, EventArgs e)
        {
            ChangeColorBySelectedRole((Label)sender);
        }

        private void ChangeColorBySelectedRole(Label lbl_SelectedRole)
        {
            GetMainForm().DisplayScreenKeyboard(false);
            foreach (Label lbl in panel_RoleType.Controls)
            {
                if (lbl == lbl_SelectedRole)
                {
                    lbl.BackColor = Color.BlueViolet;
                    lbl.ForeColor = Color.Yellow;
                }
                else
                {
                    lbl.BackColor = Color.Silver;
                    lbl.ForeColor = Color.Black;
                }
            }
            GetMainForm().currentUserType = (BLL.User.RoleType)Enum.Parse(typeof(BLL.User.RoleType), lbl_SelectedRole.Tag.ToString());
        }
        #endregion

        #region 验证类型切换
        private void label_Fingerprint_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeColorByMouseDown((Label)sender);
        }

        /// <summary>
        /// 指纹登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Fingerprint_MouseUp(object sender, MouseEventArgs e)
        {
            label_Fingerprint.Enabled = false;
            if (true == Convert.ToBoolean(((Label)sender).Tag))
            {
                ChangeColorByMouseUp((Label)sender);
                ChangeColorBySelectedCheckType((Label)sender);
                CheckFingerprint();
            }
            else
            {
                ChangeColorByMouseUp((Label)sender);
                ChangeColorBySelectedCheckType((Label)sender);
            }
            label_Fingerprint.Enabled = true;
        }

        private void label_Password_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeColorByMouseDown((Label)sender);
        }

        private void label_Password_MouseUp(object sender, MouseEventArgs e)
        {
            label_Password.Enabled = false;
            if (true == Convert.ToBoolean(((Label)sender).Tag))
            {
                ChangeColorByMouseUp((Label)sender);
                ChangeColorBySelectedCheckType((Label)sender);
                CheckPassword();
            }
            else
            {
                ChangeColorByMouseUp((Label)sender);
                ChangeColorBySelectedCheckType((Label)sender);
            }
            label_Password.Enabled = true;
        }

        /// <summary>
        /// 更新登录描述
        /// </summary>
        /// <param name="message"></param>
        /// <param name="fontColor"></param>
        private void UpdateLoginDescription(string message, bool twinkleFontColor)
        {
            label_Description.Text = message;
            if (twinkleFontColor)
            {
                TwinkleControlFontColor(label_Description, Color.Red);
            }
            Application.DoEvents();
        }

        /// <summary>
        /// 验证密码
        /// </summary>
        private void CheckPassword()
        {
            GetMainForm().DisplayScreenKeyboard(false);
            string strCheckLoginMsg = string.Empty;
            if (string.IsNullOrEmpty(textBox_UserNumber.Text))
            {
                strCheckLoginMsg = "请输入人员编号！";
                textBox_UserNumber.Focus();
                UpdateLoginDescription(string.Format("{0}", strCheckLoginMsg), true);
                GetMainForm().DisplayScreenKeyboard(true);
                return;
            }
            if (string.IsNullOrEmpty(textBox_Pwd.Text))
            {
                strCheckLoginMsg = "请输入密码！";
                textBox_Pwd.Focus();
                UpdateLoginDescription(string.Format("{0}", strCheckLoginMsg), true);
                GetMainForm().PlaySound(Utils.Config.soundFile_InputPwd);
                GetMainForm().DisplayScreenKeyboard(true);
                return;
            }
            UpdateLoginDescription("正在登录...", false);
            Thread.Sleep(500);
            if (false == GetMainForm().CheckLoginByPwd(textBox_UserNumber.Text, textBox_Pwd.Text, ref strCheckLoginMsg))
            {
                UpdateLoginDescription(string.Format("{0}", strCheckLoginMsg), true);
            }
            else
            {
                UpdateLoginDescription("登录成功！", false);
            }
        }

        /// <summary>
        /// 验证指纹
        /// </summary>
        private void CheckFingerprint()
        {
            GetMainForm().DisplayScreenKeyboard(false);
            //TODO::验证指纹            
            object fingerprintInfo = null;
            string strCheckLoginMsg = string.Empty;
            if (string.IsNullOrEmpty(textBox_UserNumber.Text))
            {
                strCheckLoginMsg = "请输入人员编号！";
                textBox_UserNumber.Focus();
                UpdateLoginDescription(string.Format("{0}", strCheckLoginMsg), true);
                GetMainForm().DisplayScreenKeyboard(true);
                return;
            }
            if (null == fingerprintInfo)
            {
                strCheckLoginMsg = "请验证指纹！";
                UpdateLoginDescription(string.Format("{0}", strCheckLoginMsg), true);
                return;
            }
            UpdateLoginDescription("正在登录...", false);
            Thread.Sleep(500);
            if (false == GetMainForm().CheckLoginByFingerprint(textBox_UserNumber.Text, fingerprintInfo, ref strCheckLoginMsg))
            {
                UpdateLoginDescription(string.Format("{0}", strCheckLoginMsg), true);
            }
            else
            {
                UpdateLoginDescription("登录成功！", false);
            }
        }

        /// <summary>
        /// 按下
        /// </summary>
        /// <param name="lbl"></param>
        private void ChangeColorByMouseDown(Label lbl)
        {
            lbl.ForeColor = Color.Red;
            lbl.BackColor = Color.White;
        }

        /// <summary>
        /// 弹起
        /// </summary>
        /// <param name="lbl"></param>
        private void ChangeColorByMouseUp(Label lbl)
        {
            lbl.ForeColor = Color.Black;
            lbl.BackColor = Color.Silver;
        }

        private void ChangeColorBySelectedCheckType(Label lbl_SelectedCheckType)
        {
            GetMainForm().DisplayScreenKeyboard(false);
            foreach (Label lbl in panel_CheckType.Controls)
            {
                if (lbl == lbl_SelectedCheckType)
                {
                    lbl_SelectedCheckType.Tag = true;
                    lbl.BackColor = Color.Red;
                    lbl.ForeColor = Color.Yellow;
                }
                else
                {
                    lbl.Tag = false;
                    lbl.BackColor = Color.Silver;
                    lbl.ForeColor = Color.Black;
                }
            }
        }
        #endregion

        public void Clear()
        {
            this.label_Description.Text = "请选择您的身份进入系统！";
            ChangeColorBySelectedRole(label_Operator);
            ChangeColorBySelectedCheckType(label_Password);
            this.textBox_UserNumber.Clear();
            this.textBox_Pwd.Clear();
        }


        private void timer_UpdateUI_Tick(object sender, EventArgs e)
        {
            if (label_ProgramName.Location.X > -label_ProgramName.Width)
            {
                label_ProgramName.Location = new Point(label_ProgramName.Location.X - 1, label_ProgramName.Location.Y);
            }
            else
            {
                label_ProgramName.Location = new Point(this.Width, label_ProgramName.Location.Y);
            }
        }

        private void ShowScreenKeyboardByClieck(object sender, EventArgs e)
        {
            GetMainForm().DisplayScreenKeyboard(true);
        }

        private void KeyUpToLogin(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (Convert.ToBoolean(label_Fingerprint.Tag))
                {
                    CheckFingerprint();
                }
                else
                {
                    CheckPassword();
                }
            }
        }
    }
}