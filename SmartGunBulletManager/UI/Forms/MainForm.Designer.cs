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
            this.mainFrame1 = new SmartGunBulletManager.UI.UserControls.MainFrame();
            this.loginControl1 = new SmartGunBulletManager.UI.UserControls.LoginControl();
            this.SuspendLayout();
            // 
            // timer_UpdateUI
            // 
            this.timer_UpdateUI.Tick += new System.EventHandler(this.timer_UpdateUI_Tick);
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
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.loginControl1.Location = new System.Drawing.Point(219, 194);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(586, 380);
            this.loginControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.mainFrame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "枪弹柜";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.MainFrame mainFrame1;
        private System.Windows.Forms.Timer timer_UpdateUI;
        private UserControls.LoginControl loginControl1;

    }
}

