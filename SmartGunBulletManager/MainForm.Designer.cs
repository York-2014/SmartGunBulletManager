namespace SmartGunBulletManager
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
            this.loginControl1 = new SmartGunBulletManager.MyControls.LoginControl();
            this.main1 = new SmartGunBulletManager.MyControls.Main();
            this.SuspendLayout();
            // 
            // timer_UpdateUI
            // 
            this.timer_UpdateUI.Tick += new System.EventHandler(this.timer_UpdateUI_Tick);
            // 
            // loginControl1
            // 
            this.loginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.loginControl1.Location = new System.Drawing.Point(219, 207);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(586, 355);
            this.loginControl1.TabIndex = 1;
            // 
            // main1
            // 
            this.main1.BackColor = System.Drawing.Color.Transparent;
            this.main1.Location = new System.Drawing.Point(0, 0);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(1024, 768);
            this.main1.TabIndex = 0;
            this.main1.Visible = false;
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
            this.Controls.Add(this.main1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "枪弹柜";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.Main main1;
        private MyControls.LoginControl loginControl1;
        private System.Windows.Forms.Timer timer_UpdateUI;

    }
}

