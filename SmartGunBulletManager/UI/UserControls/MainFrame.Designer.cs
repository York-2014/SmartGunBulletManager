namespace SmartGunBulletManager.UI.UserControls
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.panel_MiddleStateBar = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_GunCount = new System.Windows.Forms.Label();
            this.label_Operator = new System.Windows.Forms.Label();
            this.label_DateTime = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_SystemName = new System.Windows.Forms.Label();
            this.pictureBox_Top = new System.Windows.Forms.PictureBox();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.bodyContent_Main = new SmartGunBulletManager.UI.UserControls.Dashboard();
            this.panel_MiddleStateBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).BeginInit();
            this.panel_Body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MiddleStateBar
            // 
            this.panel_MiddleStateBar.BackColor = System.Drawing.Color.White;
            this.panel_MiddleStateBar.Controls.Add(this.pictureBox6);
            this.panel_MiddleStateBar.Controls.Add(this.pictureBox5);
            this.panel_MiddleStateBar.Controls.Add(this.pictureBox4);
            this.panel_MiddleStateBar.Controls.Add(this.label_GunCount);
            this.panel_MiddleStateBar.Controls.Add(this.label_Operator);
            this.panel_MiddleStateBar.Controls.Add(this.label_DateTime);
            this.panel_MiddleStateBar.Location = new System.Drawing.Point(0, 150);
            this.panel_MiddleStateBar.Name = "panel_MiddleStateBar";
            this.panel_MiddleStateBar.Size = new System.Drawing.Size(1024, 30);
            this.panel_MiddleStateBar.TabIndex = 5;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(745, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(425, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // label_GunCount
            // 
            this.label_GunCount.AutoSize = true;
            this.label_GunCount.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label_GunCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_GunCount.Location = new System.Drawing.Point(451, 8);
            this.label_GunCount.Name = "label_GunCount";
            this.label_GunCount.Size = new System.Drawing.Size(122, 14);
            this.label_GunCount.TabIndex = 2;
            this.label_GunCount.Text = "枪支数量：20/25";
            // 
            // label_Operator
            // 
            this.label_Operator.AutoSize = true;
            this.label_Operator.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label_Operator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_Operator.Location = new System.Drawing.Point(47, 8);
            this.label_Operator.Name = "label_Operator";
            this.label_Operator.Size = new System.Drawing.Size(97, 14);
            this.label_Operator.TabIndex = 1;
            this.label_Operator.Text = "值班员：张三";
            // 
            // label_DateTime
            // 
            this.label_DateTime.AutoSize = true;
            this.label_DateTime.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label_DateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_DateTime.Location = new System.Drawing.Point(771, 8);
            this.label_DateTime.Name = "label_DateTime";
            this.label_DateTime.Size = new System.Drawing.Size(82, 14);
            this.label_DateTime.TabIndex = 0;
            this.label_DateTime.Text = "当前时间：";
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Transparent;
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Controls.Add(this.label_SystemName);
            this.panel_Top.Controls.Add(this.pictureBox_Top);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1024, 150);
            this.panel_Top.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(944, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "v1.0 Beta";
            // 
            // label_SystemName
            // 
            this.label_SystemName.AutoSize = true;
            this.label_SystemName.BackColor = System.Drawing.Color.Transparent;
            this.label_SystemName.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.label_SystemName.ForeColor = System.Drawing.Color.White;
            this.label_SystemName.Location = new System.Drawing.Point(45, 58);
            this.label_SystemName.Name = "label_SystemName";
            this.label_SystemName.Size = new System.Drawing.Size(330, 34);
            this.label_SystemName.TabIndex = 2;
            this.label_SystemName.Text = "智能枪弹柜管理系统";
            // 
            // pictureBox_Top
            // 
            this.pictureBox_Top.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Top.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Top.Name = "pictureBox_Top";
            this.pictureBox_Top.Size = new System.Drawing.Size(1024, 150);
            this.pictureBox_Top.TabIndex = 0;
            this.pictureBox_Top.TabStop = false;
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.Transparent;
            this.panel_Body.Controls.Add(this.bodyContent_Main);
            this.panel_Body.Location = new System.Drawing.Point(0, 180);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1024, 588);
            this.panel_Body.TabIndex = 7;
            // 
            // bodyContent_Main
            // 
            this.bodyContent_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.bodyContent_Main.Location = new System.Drawing.Point(12, 15);
            this.bodyContent_Main.Name = "bodyContent_Main";
            this.bodyContent_Main.Size = new System.Drawing.Size(1000, 560);
            this.bodyContent_Main.TabIndex = 5;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_MiddleStateBar);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Body);
            this.Name = "MainFrame";
            this.Size = new System.Drawing.Size(1024, 768);
            this.panel_MiddleStateBar.ResumeLayout(false);
            this.panel_MiddleStateBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).EndInit();
            this.panel_Body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MiddleStateBar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_GunCount;
        private System.Windows.Forms.Label label_Operator;
        private System.Windows.Forms.Label label_DateTime;
        private System.Windows.Forms.PictureBox pictureBox_Top;
        private System.Windows.Forms.Label label_SystemName;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Body;
        private Dashboard bodyContent_Main;
    }
}
