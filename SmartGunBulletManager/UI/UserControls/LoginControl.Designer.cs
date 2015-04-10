namespace SmartGunBulletManager.UI.UserControls
{
    partial class LoginControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Fingerprint = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_UserNumber = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Admin = new System.Windows.Forms.Label();
            this.label_Holder = new System.Windows.Forms.Label();
            this.label_Operator = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.label_ProgramName = new System.Windows.Forms.Label();
            this.panel_RoleType = new System.Windows.Forms.Panel();
            this.panel_CheckType = new System.Windows.Forms.Panel();
            this.timer_UpdateUI = new System.Windows.Forms.Timer(this.components);
            this.label_Copyright = new System.Windows.Forms.Label();
            this.panel_RoleType.SuspendLayout();
            this.panel_CheckType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Fingerprint
            // 
            this.label_Fingerprint.BackColor = System.Drawing.Color.Silver;
            this.label_Fingerprint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Fingerprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Fingerprint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Fingerprint.ForeColor = System.Drawing.Color.Black;
            this.label_Fingerprint.Location = new System.Drawing.Point(8, 0);
            this.label_Fingerprint.Name = "label_Fingerprint";
            this.label_Fingerprint.Size = new System.Drawing.Size(93, 38);
            this.label_Fingerprint.TabIndex = 2;
            this.label_Fingerprint.Tag = "false";
            this.label_Fingerprint.Text = "指纹验证";
            this.label_Fingerprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Fingerprint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Fingerprint_MouseDown);
            this.label_Fingerprint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_Fingerprint_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(89, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "输入密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "人员编号：";
            // 
            // textBox_UserNumber
            // 
            this.textBox_UserNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UserNumber.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox_UserNumber.Location = new System.Drawing.Point(190, 212);
            this.textBox_UserNumber.Name = "textBox_UserNumber";
            this.textBox_UserNumber.Size = new System.Drawing.Size(200, 38);
            this.textBox_UserNumber.TabIndex = 0;
            // 
            // label_Password
            // 
            this.label_Password.BackColor = System.Drawing.Color.Red;
            this.label_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Password.ForeColor = System.Drawing.Color.Yellow;
            this.label_Password.Location = new System.Drawing.Point(8, 66);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(93, 38);
            this.label_Password.TabIndex = 3;
            this.label_Password.Tag = "true";
            this.label_Password.Text = "密码验证";
            this.label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Password_MouseDown);
            this.label_Password.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_Password_MouseUp);
            // 
            // label_Admin
            // 
            this.label_Admin.BackColor = System.Drawing.Color.Silver;
            this.label_Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Admin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Admin.ForeColor = System.Drawing.Color.Black;
            this.label_Admin.Location = new System.Drawing.Point(339, 23);
            this.label_Admin.Name = "label_Admin";
            this.label_Admin.Size = new System.Drawing.Size(110, 40);
            this.label_Admin.TabIndex = 6;
            this.label_Admin.Tag = "Admin";
            this.label_Admin.Text = "管理员";
            this.label_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Admin.Click += new System.EventHandler(this.label_Admin_Click);
            // 
            // label_Holder
            // 
            this.label_Holder.BackColor = System.Drawing.Color.Silver;
            this.label_Holder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Holder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Holder.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Holder.ForeColor = System.Drawing.Color.Black;
            this.label_Holder.Location = new System.Drawing.Point(190, 23);
            this.label_Holder.Name = "label_Holder";
            this.label_Holder.Size = new System.Drawing.Size(110, 40);
            this.label_Holder.TabIndex = 5;
            this.label_Holder.Tag = "Holder";
            this.label_Holder.Text = "持枪人";
            this.label_Holder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Holder.Click += new System.EventHandler(this.label_Holder_Click);
            // 
            // label_Operator
            // 
            this.label_Operator.BackColor = System.Drawing.Color.BlueViolet;
            this.label_Operator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Operator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Operator.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Operator.ForeColor = System.Drawing.Color.Yellow;
            this.label_Operator.Location = new System.Drawing.Point(41, 23);
            this.label_Operator.Name = "label_Operator";
            this.label_Operator.Size = new System.Drawing.Size(110, 40);
            this.label_Operator.TabIndex = 4;
            this.label_Operator.Tag = "Operator";
            this.label_Operator.Text = "值班员";
            this.label_Operator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Operator.Click += new System.EventHandler(this.label_Operator_Click);
            // 
            // label_Description
            // 
            this.label_Description.BackColor = System.Drawing.Color.Transparent;
            this.label_Description.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Description.ForeColor = System.Drawing.Color.Yellow;
            this.label_Description.Location = new System.Drawing.Point(6, 91);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(577, 28);
            this.label_Description.TabIndex = 6;
            this.label_Description.Text = "请选择您的身份进入系统！";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Pwd.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox_Pwd.Location = new System.Drawing.Point(190, 277);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.PasswordChar = '*';
            this.textBox_Pwd.Size = new System.Drawing.Size(200, 38);
            this.textBox_Pwd.TabIndex = 1;
            // 
            // label_ProgramName
            // 
            this.label_ProgramName.AutoSize = true;
            this.label_ProgramName.BackColor = System.Drawing.Color.Transparent;
            this.label_ProgramName.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.label_ProgramName.ForeColor = System.Drawing.Color.White;
            this.label_ProgramName.Location = new System.Drawing.Point(128, 37);
            this.label_ProgramName.Name = "label_ProgramName";
            this.label_ProgramName.Size = new System.Drawing.Size(330, 34);
            this.label_ProgramName.TabIndex = 4;
            this.label_ProgramName.Text = "智能枪弹柜管理系统";
            this.label_ProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_RoleType
            // 
            this.panel_RoleType.BackColor = System.Drawing.Color.Transparent;
            this.panel_RoleType.Controls.Add(this.label_Holder);
            this.panel_RoleType.Controls.Add(this.label_Operator);
            this.panel_RoleType.Controls.Add(this.label_Admin);
            this.panel_RoleType.Location = new System.Drawing.Point(48, 122);
            this.panel_RoleType.Name = "panel_RoleType";
            this.panel_RoleType.Size = new System.Drawing.Size(490, 84);
            this.panel_RoleType.TabIndex = 15;
            // 
            // panel_CheckType
            // 
            this.panel_CheckType.BackColor = System.Drawing.Color.Transparent;
            this.panel_CheckType.Controls.Add(this.label_Fingerprint);
            this.panel_CheckType.Controls.Add(this.label_Password);
            this.panel_CheckType.Location = new System.Drawing.Point(396, 212);
            this.panel_CheckType.Name = "panel_CheckType";
            this.panel_CheckType.Size = new System.Drawing.Size(110, 105);
            this.panel_CheckType.TabIndex = 16;
            // 
            // timer_UpdateUI
            // 
            this.timer_UpdateUI.Tick += new System.EventHandler(this.timer_UpdateUI_Tick);
            // 
            // label_Copyright
            // 
            this.label_Copyright.BackColor = System.Drawing.Color.Transparent;
            this.label_Copyright.Font = new System.Drawing.Font("微软雅黑", 8.25F);
            this.label_Copyright.ForeColor = System.Drawing.Color.Silver;
            this.label_Copyright.Location = new System.Drawing.Point(3, 350);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(580, 16);
            this.label_Copyright.TabIndex = 18;
            this.label_Copyright.Text = "Copyright © 2015 Jiangxi Pioneer. All Rights Reserved.";
            this.label_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.panel_RoleType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_UserNumber);
            this.Controls.Add(this.textBox_Pwd);
            this.Controls.Add(this.panel_CheckType);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_ProgramName);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(586, 380);
            this.panel_RoleType.ResumeLayout(false);
            this.panel_CheckType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ProgramName;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Operator;
        private System.Windows.Forms.Label label_Holder;
        private System.Windows.Forms.Label label_Admin;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_UserNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Fingerprint;
        private System.Windows.Forms.Panel panel_RoleType;
        private System.Windows.Forms.Panel panel_CheckType;
        private System.Windows.Forms.Timer timer_UpdateUI;
        private System.Windows.Forms.Label label_Copyright;
    }
}
