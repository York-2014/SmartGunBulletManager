namespace SmartGunBulletManager.UI.Forms
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer_UpdateUI = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.screenKeyboard1 = new SmartGunBulletManager.UI.UserControls.ScreenKeyboard();
            this.loginControl1 = new SmartGunBulletManager.UI.UserControls.LoginControl();
            this.mainFrame1 = new SmartGunBulletManager.UI.UserControls.MainFrame();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_UpdateUI
            // 
            this.timer_UpdateUI.Tick += new System.EventHandler(this.timer_UpdateUI_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // screenKeyboard1
            // 
            this.screenKeyboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.screenKeyboard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenKeyboard1.Location = new System.Drawing.Point(735, 440);
            this.screenKeyboard1.Name = "screenKeyboard1";
            this.screenKeyboard1.Size = new System.Drawing.Size(278, 318);
            this.screenKeyboard1.TabIndex = 2;
            this.screenKeyboard1.TabStop = false;
            this.screenKeyboard1.Visible = false;
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.loginControl1.Location = new System.Drawing.Point(219, 194);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(586, 380);
            this.loginControl1.TabIndex = 1;
            // 
            // mainFrame1
            // 
            this.mainFrame1.BackColor = System.Drawing.Color.Transparent;
            this.mainFrame1.Enabled = false;
            this.mainFrame1.Location = new System.Drawing.Point(0, 0);
            this.mainFrame1.Name = "mainFrame1";
            this.mainFrame1.Size = new System.Drawing.Size(1024, 768);
            this.mainFrame1.TabIndex = 0;
            this.mainFrame1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.screenKeyboard1);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.mainFrame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能枪弹柜管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.MainFrame mainFrame1;
        private System.Windows.Forms.Timer timer_UpdateUI;
        private UserControls.LoginControl loginControl1;
        private UserControls.ScreenKeyboard screenKeyboard1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;

    }
}

