using System;
using System.Drawing;
using System.Windows.Forms;
using SmartGunBulletManager.Forms;

namespace SmartGunBulletManager.UserControls
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
            ChangeColorByMouseUp((Label)sender);
            ChangeColorBySelectedCheckType((Label)sender);
            CheckFingerprintLogic();
        }

        private void label_Password_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeColorByMouseDown((Label)sender);
        }

        private void label_Password_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeColorByMouseUp((Label)sender);
            ChangeColorBySelectedCheckType((Label)sender);
            CheckPasswordLogic();
        }

        /// <summary>
        /// 验证密码
        /// </summary>
        private void CheckPasswordLogic()
        {
            string strCheckLoginMsg = string.Empty;
            if (false == ((MainForm)TopLevelControl).CheckLogin(textBox_User.Text, textBox_Pwd.Text, ref strCheckLoginMsg))
            {
                MessageBox.Show(strCheckLoginMsg, "验证失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(strCheckLoginMsg, "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 验证指纹
        /// </summary>
        private void CheckFingerprintLogic()
        {
            //TODO::验证指纹
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
            foreach (Label lbl in panel_CheckType.Controls)
            {
                if (lbl == lbl_SelectedCheckType)
                {
                    lbl.BackColor = Color.Red;
                    lbl.ForeColor = Color.Yellow;
                }
                else
                {
                    lbl.BackColor = Color.Silver;
                    lbl.ForeColor = Color.Black;
                }
            }
        }
        #endregion


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
    }
}