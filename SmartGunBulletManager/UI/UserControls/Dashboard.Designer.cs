namespace SmartGunBulletManager.UI.UserControls
{
    partial class Dashboard
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
            this.label_CabinetCount = new System.Windows.Forms.Label();
            this.label_LockStateComment = new System.Windows.Forms.Label();
            this.panel_BottomStateBar = new System.Windows.Forms.Panel();
            this.pictureBox_ServerState = new System.Windows.Forms.PictureBox();
            this.pictureBox_NetworkState = new System.Windows.Forms.PictureBox();
            this.pictureBox_PowerState = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_sd = new System.Windows.Forms.PictureBox();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.pictureBox_wd = new System.Windows.Forms.PictureBox();
            this.label_AlcoholConcentration = new System.Windows.Forms.Label();
            this.label_Humidity = new System.Windows.Forms.Label();
            this.pictureBox_LockScreen = new System.Windows.Forms.PictureBox();
            this.blockButton_Exit = new SmartGunBulletManager.UI.UserControls.BlockButton();
            this.blockButton_Help = new SmartGunBulletManager.UI.UserControls.BlockButton();
            this.pictureBox_Cabinet = new System.Windows.Forms.PictureBox();
            this.pictureBox_LockState = new System.Windows.Forms.PictureBox();
            this.blockButton_Records = new SmartGunBulletManager.UI.UserControls.BlockButton();
            this.blockButton_SystemSettings = new SmartGunBulletManager.UI.UserControls.BlockButton();
            this.blockButton_DutyTable = new SmartGunBulletManager.UI.UserControls.BlockButton();
            this.blockButton_BackGun = new SmartGunBulletManager.UI.UserControls.BlockButton();
            this.blockButton_GetGun = new SmartGunBulletManager.UI.UserControls.BlockButton();
            this.blockButton_View = new SmartGunBulletManager.UI.UserControls.BlockButton();
            this.panel_BottomStateBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ServerState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NetworkState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PowerState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LockScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cabinet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LockState)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CabinetCount
            // 
            this.label_CabinetCount.AutoSize = true;
            this.label_CabinetCount.BackColor = System.Drawing.Color.Transparent;
            this.label_CabinetCount.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_CabinetCount.ForeColor = System.Drawing.Color.Yellow;
            this.label_CabinetCount.Location = new System.Drawing.Point(59, 24);
            this.label_CabinetCount.Name = "label_CabinetCount";
            this.label_CabinetCount.Size = new System.Drawing.Size(82, 19);
            this.label_CabinetCount.TabIndex = 30;
            this.label_CabinetCount.Text = "枪柜数量：2";
            // 
            // label_LockStateComment
            // 
            this.label_LockStateComment.AutoSize = true;
            this.label_LockStateComment.BackColor = System.Drawing.Color.Transparent;
            this.label_LockStateComment.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_LockStateComment.ForeColor = System.Drawing.Color.Yellow;
            this.label_LockStateComment.Location = new System.Drawing.Point(217, 24);
            this.label_LockStateComment.Name = "label_LockStateComment";
            this.label_LockStateComment.Size = new System.Drawing.Size(139, 19);
            this.label_LockStateComment.TabIndex = 28;
            this.label_LockStateComment.Text = "柜门状态：已全部关闭";
            // 
            // panel_BottomStateBar
            // 
            this.panel_BottomStateBar.BackColor = System.Drawing.Color.White;
            this.panel_BottomStateBar.Controls.Add(this.pictureBox_ServerState);
            this.panel_BottomStateBar.Controls.Add(this.pictureBox_NetworkState);
            this.panel_BottomStateBar.Controls.Add(this.pictureBox_PowerState);
            this.panel_BottomStateBar.Controls.Add(this.pictureBox3);
            this.panel_BottomStateBar.Controls.Add(this.pictureBox_sd);
            this.panel_BottomStateBar.Controls.Add(this.label_Temperature);
            this.panel_BottomStateBar.Controls.Add(this.pictureBox_wd);
            this.panel_BottomStateBar.Controls.Add(this.label_AlcoholConcentration);
            this.panel_BottomStateBar.Controls.Add(this.label_Humidity);
            this.panel_BottomStateBar.Location = new System.Drawing.Point(0, 522);
            this.panel_BottomStateBar.Name = "panel_BottomStateBar";
            this.panel_BottomStateBar.Size = new System.Drawing.Size(1000, 38);
            this.panel_BottomStateBar.TabIndex = 26;
            // 
            // pictureBox_ServerState
            // 
            this.pictureBox_ServerState.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ServerState.Image = global::SmartGunBulletManager.Properties.Resources.Server_Online_32;
            this.pictureBox_ServerState.Location = new System.Drawing.Point(957, 7);
            this.pictureBox_ServerState.Name = "pictureBox_ServerState";
            this.pictureBox_ServerState.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_ServerState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ServerState.TabIndex = 13;
            this.pictureBox_ServerState.TabStop = false;
            // 
            // pictureBox_NetworkState
            // 
            this.pictureBox_NetworkState.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_NetworkState.Image = global::SmartGunBulletManager.Properties.Resources.Network_Connected_32;
            this.pictureBox_NetworkState.Location = new System.Drawing.Point(919, 7);
            this.pictureBox_NetworkState.Name = "pictureBox_NetworkState";
            this.pictureBox_NetworkState.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_NetworkState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_NetworkState.TabIndex = 12;
            this.pictureBox_NetworkState.TabStop = false;
            // 
            // pictureBox_PowerState
            // 
            this.pictureBox_PowerState.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PowerState.Image = global::SmartGunBulletManager.Properties.Resources.Power_Normal_32;
            this.pictureBox_PowerState.Location = new System.Drawing.Point(881, 7);
            this.pictureBox_PowerState.Name = "pictureBox_PowerState";
            this.pictureBox_PowerState.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_PowerState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_PowerState.TabIndex = 11;
            this.pictureBox_PowerState.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SmartGunBulletManager.Properties.Resources.jjnd_32;
            this.pictureBox3.Location = new System.Drawing.Point(326, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox_sd
            // 
            this.pictureBox_sd.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_sd.Image = global::SmartGunBulletManager.Properties.Resources.sd_32;
            this.pictureBox_sd.Location = new System.Drawing.Point(168, 9);
            this.pictureBox_sd.Name = "pictureBox_sd";
            this.pictureBox_sd.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_sd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sd.TabIndex = 6;
            this.pictureBox_sd.TabStop = false;
            // 
            // label_Temperature
            // 
            this.label_Temperature.AutoSize = true;
            this.label_Temperature.BackColor = System.Drawing.Color.Transparent;
            this.label_Temperature.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label_Temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_Temperature.Location = new System.Drawing.Point(47, 12);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(83, 14);
            this.label_Temperature.TabIndex = 1;
            this.label_Temperature.Text = "温度：0 ℃";
            // 
            // pictureBox_wd
            // 
            this.pictureBox_wd.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_wd.Image = global::SmartGunBulletManager.Properties.Resources.wd_32;
            this.pictureBox_wd.Location = new System.Drawing.Point(21, 9);
            this.pictureBox_wd.Name = "pictureBox_wd";
            this.pictureBox_wd.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_wd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_wd.TabIndex = 5;
            this.pictureBox_wd.TabStop = false;
            // 
            // label_AlcoholConcentration
            // 
            this.label_AlcoholConcentration.AutoSize = true;
            this.label_AlcoholConcentration.BackColor = System.Drawing.Color.Transparent;
            this.label_AlcoholConcentration.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label_AlcoholConcentration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_AlcoholConcentration.Location = new System.Drawing.Point(352, 12);
            this.label_AlcoholConcentration.Name = "label_AlcoholConcentration";
            this.label_AlcoholConcentration.Size = new System.Drawing.Size(162, 14);
            this.label_AlcoholConcentration.TabIndex = 4;
            this.label_AlcoholConcentration.Text = "酒精浓度：0 mg/100ml";
            // 
            // label_Humidity
            // 
            this.label_Humidity.AutoSize = true;
            this.label_Humidity.BackColor = System.Drawing.Color.Transparent;
            this.label_Humidity.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.label_Humidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_Humidity.Location = new System.Drawing.Point(194, 12);
            this.label_Humidity.Name = "label_Humidity";
            this.label_Humidity.Size = new System.Drawing.Size(92, 14);
            this.label_Humidity.TabIndex = 3;
            this.label_Humidity.Text = "湿度：0 %RH";
            // 
            // pictureBox_LockScreen
            // 
            this.pictureBox_LockScreen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LockScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_LockScreen.Image = global::SmartGunBulletManager.Properties.Resources.sp_48;
            this.pictureBox_LockScreen.Location = new System.Drawing.Point(961, 3);
            this.pictureBox_LockScreen.Name = "pictureBox_LockScreen";
            this.pictureBox_LockScreen.Size = new System.Drawing.Size(36, 32);
            this.pictureBox_LockScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_LockScreen.TabIndex = 33;
            this.pictureBox_LockScreen.TabStop = false;
            this.pictureBox_LockScreen.Click += new System.EventHandler(this.pictureBox_LockScreen_Click);
            // 
            // blockButton_Exit
            // 
            this.blockButton_Exit.BackColor = System.Drawing.Color.Lavender;
            this.blockButton_Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockButton_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockButton_Exit.Description = "退  出";
            this.blockButton_Exit.Icon = global::SmartGunBulletManager.Properties.Resources.exit_32;
            this.blockButton_Exit.Location = new System.Drawing.Point(381, 353);
            this.blockButton_Exit.Name = "blockButton_Exit";
            this.blockButton_Exit.Size = new System.Drawing.Size(240, 100);
            this.blockButton_Exit.TabIndex = 32;
            this.blockButton_Exit.BlockClick += new SmartGunBulletManager.UI.UserControls.BlockButton.EventHandler(this.blockButton_Exit_BlockClick);
            // 
            // blockButton_Help
            // 
            this.blockButton_Help.BackColor = System.Drawing.Color.DarkOrange;
            this.blockButton_Help.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockButton_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockButton_Help.Description = "使用说明";
            this.blockButton_Help.Icon = global::SmartGunBulletManager.Properties.Resources.help_32;
            this.blockButton_Help.Location = new System.Drawing.Point(688, 215);
            this.blockButton_Help.Name = "blockButton_Help";
            this.blockButton_Help.Size = new System.Drawing.Size(240, 100);
            this.blockButton_Help.TabIndex = 31;
            // 
            // pictureBox_Cabinet
            // 
            this.pictureBox_Cabinet.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Cabinet.Image = global::SmartGunBulletManager.Properties.Resources.qg_32;
            this.pictureBox_Cabinet.Location = new System.Drawing.Point(21, 15);
            this.pictureBox_Cabinet.Name = "pictureBox_Cabinet";
            this.pictureBox_Cabinet.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_Cabinet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Cabinet.TabIndex = 29;
            this.pictureBox_Cabinet.TabStop = false;
            // 
            // pictureBox_LockState
            // 
            this.pictureBox_LockState.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LockState.Image = global::SmartGunBulletManager.Properties.Resources.locked_32;
            this.pictureBox_LockState.Location = new System.Drawing.Point(179, 15);
            this.pictureBox_LockState.Name = "pictureBox_LockState";
            this.pictureBox_LockState.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_LockState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_LockState.TabIndex = 27;
            this.pictureBox_LockState.TabStop = false;
            // 
            // blockButton_Records
            // 
            this.blockButton_Records.BackColor = System.Drawing.Color.Gold;
            this.blockButton_Records.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockButton_Records.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockButton_Records.Description = "记录查询";
            this.blockButton_Records.Icon = global::SmartGunBulletManager.Properties.Resources.records_32;
            this.blockButton_Records.Location = new System.Drawing.Point(381, 215);
            this.blockButton_Records.Name = "blockButton_Records";
            this.blockButton_Records.Size = new System.Drawing.Size(240, 100);
            this.blockButton_Records.TabIndex = 25;
            // 
            // blockButton_SystemSettings
            // 
            this.blockButton_SystemSettings.BackColor = System.Drawing.Color.Lavender;
            this.blockButton_SystemSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockButton_SystemSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockButton_SystemSettings.Description = "系统设置";
            this.blockButton_SystemSettings.Icon = global::SmartGunBulletManager.Properties.Resources.xtsz_32;
            this.blockButton_SystemSettings.Location = new System.Drawing.Point(74, 353);
            this.blockButton_SystemSettings.Name = "blockButton_SystemSettings";
            this.blockButton_SystemSettings.Size = new System.Drawing.Size(240, 100);
            this.blockButton_SystemSettings.TabIndex = 23;
            // 
            // blockButton_DutyTable
            // 
            this.blockButton_DutyTable.BackColor = System.Drawing.Color.OrangeRed;
            this.blockButton_DutyTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockButton_DutyTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockButton_DutyTable.Description = "值班表";
            this.blockButton_DutyTable.Icon = global::SmartGunBulletManager.Properties.Resources.rl_32;
            this.blockButton_DutyTable.Location = new System.Drawing.Point(74, 215);
            this.blockButton_DutyTable.Name = "blockButton_DutyTable";
            this.blockButton_DutyTable.Size = new System.Drawing.Size(240, 100);
            this.blockButton_DutyTable.TabIndex = 22;
            // 
            // blockButton_BackGun
            // 
            this.blockButton_BackGun.BackColor = System.Drawing.Color.RosyBrown;
            this.blockButton_BackGun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockButton_BackGun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockButton_BackGun.Description = "还    枪";
            this.blockButton_BackGun.Icon = global::SmartGunBulletManager.Properties.Resources.hq_32;
            this.blockButton_BackGun.Location = new System.Drawing.Point(688, 77);
            this.blockButton_BackGun.Name = "blockButton_BackGun";
            this.blockButton_BackGun.Size = new System.Drawing.Size(240, 100);
            this.blockButton_BackGun.TabIndex = 21;
            this.blockButton_BackGun.BlockClick += new SmartGunBulletManager.UI.UserControls.BlockButton.EventHandler(this.blockButton_BackGun_Click);
            // 
            // blockButton_GetGun
            // 
            this.blockButton_GetGun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.blockButton_GetGun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockButton_GetGun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockButton_GetGun.Description = "取    枪";
            this.blockButton_GetGun.Icon = global::SmartGunBulletManager.Properties.Resources.qq_32;
            this.blockButton_GetGun.Location = new System.Drawing.Point(381, 77);
            this.blockButton_GetGun.Name = "blockButton_GetGun";
            this.blockButton_GetGun.Size = new System.Drawing.Size(240, 100);
            this.blockButton_GetGun.TabIndex = 20;
            this.blockButton_GetGun.BlockClick += new SmartGunBulletManager.UI.UserControls.BlockButton.EventHandler(this.blockButton_GetGun_Click);
            // 
            // blockButton_View
            // 
            this.blockButton_View.BackColor = System.Drawing.Color.BurlyWood;
            this.blockButton_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockButton_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blockButton_View.Description = "状态查看";
            this.blockButton_View.Icon = global::SmartGunBulletManager.Properties.Resources.find_32;
            this.blockButton_View.Location = new System.Drawing.Point(74, 77);
            this.blockButton_View.Name = "blockButton_View";
            this.blockButton_View.Size = new System.Drawing.Size(240, 100);
            this.blockButton_View.TabIndex = 19;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_LockScreen);
            this.Controls.Add(this.blockButton_Exit);
            this.Controls.Add(this.blockButton_Help);
            this.Controls.Add(this.label_CabinetCount);
            this.Controls.Add(this.pictureBox_Cabinet);
            this.Controls.Add(this.label_LockStateComment);
            this.Controls.Add(this.pictureBox_LockState);
            this.Controls.Add(this.panel_BottomStateBar);
            this.Controls.Add(this.blockButton_Records);
            this.Controls.Add(this.blockButton_SystemSettings);
            this.Controls.Add(this.blockButton_DutyTable);
            this.Controls.Add(this.blockButton_BackGun);
            this.Controls.Add(this.blockButton_GetGun);
            this.Controls.Add(this.blockButton_View);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1000, 560);
            this.panel_BottomStateBar.ResumeLayout(false);
            this.panel_BottomStateBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ServerState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NetworkState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PowerState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_wd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LockScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cabinet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LockState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BlockButton blockButton_Records;
        private BlockButton blockButton_SystemSettings;
        private BlockButton blockButton_DutyTable;
        private BlockButton blockButton_BackGun;
        private BlockButton blockButton_GetGun;
        private BlockButton blockButton_View;
        private System.Windows.Forms.Panel panel_BottomStateBar;
        private System.Windows.Forms.PictureBox pictureBox_ServerState;
        private System.Windows.Forms.PictureBox pictureBox_NetworkState;
        private System.Windows.Forms.PictureBox pictureBox_PowerState;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox_sd;
        private System.Windows.Forms.Label label_Temperature;
        private System.Windows.Forms.PictureBox pictureBox_wd;
        private System.Windows.Forms.Label label_AlcoholConcentration;
        private System.Windows.Forms.Label label_Humidity;
        private System.Windows.Forms.PictureBox pictureBox_LockState;
        private System.Windows.Forms.Label label_LockStateComment;
        private System.Windows.Forms.PictureBox pictureBox_Cabinet;
        private System.Windows.Forms.Label label_CabinetCount;
        private BlockButton blockButton_Help;
        private BlockButton blockButton_Exit;
        private System.Windows.Forms.PictureBox pictureBox_LockScreen;
    }
}
