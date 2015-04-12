namespace SmartGunBulletManager.UI.UserControls
{
    partial class ScreenKeyboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.keyboardButton_Clear = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_Point = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_Tab = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_Enter = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_Backspace = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_0 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_9 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_8 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_7 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_6 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_5 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_4 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_3 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_2 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.keyboardButton_1 = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyboardButton_Hide = new SmartGunBulletManager.UI.UserControls.KeyboardButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.keyboardButton_Clear);
            this.panel2.Controls.Add(this.keyboardButton_Point);
            this.panel2.Controls.Add(this.keyboardButton_Tab);
            this.panel2.Controls.Add(this.keyboardButton_Enter);
            this.panel2.Controls.Add(this.keyboardButton_Backspace);
            this.panel2.Controls.Add(this.keyboardButton_0);
            this.panel2.Controls.Add(this.keyboardButton_9);
            this.panel2.Controls.Add(this.keyboardButton_8);
            this.panel2.Controls.Add(this.keyboardButton_7);
            this.panel2.Controls.Add(this.keyboardButton_6);
            this.panel2.Controls.Add(this.keyboardButton_5);
            this.panel2.Controls.Add(this.keyboardButton_4);
            this.panel2.Controls.Add(this.keyboardButton_3);
            this.panel2.Controls.Add(this.keyboardButton_2);
            this.panel2.Controls.Add(this.keyboardButton_1);
            this.panel2.Location = new System.Drawing.Point(-1, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 284);
            this.panel2.TabIndex = 15;
            // 
            // keyboardButton_Clear
            // 
            this.keyboardButton_Clear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_Clear.KeyFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.keyboardButton_Clear.KeyValue = "清空";
            this.keyboardButton_Clear.Location = new System.Drawing.Point(207, 81);
            this.keyboardButton_Clear.Name = "keyboardButton_Clear";
            this.keyboardButton_Clear.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_Clear.TabIndex = 31;
            this.keyboardButton_Clear.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.keyboardButton_Clear_Click);
            // 
            // keyboardButton_Point
            // 
            this.keyboardButton_Point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_Point.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_Point.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_Point.KeyValue = ".";
            this.keyboardButton_Point.Location = new System.Drawing.Point(79, 209);
            this.keyboardButton_Point.Name = "keyboardButton_Point";
            this.keyboardButton_Point.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_Point.TabIndex = 30;
            this.keyboardButton_Point.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_Tab
            // 
            this.keyboardButton_Tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_Tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_Tab.KeyFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.keyboardButton_Tab.KeyValue = "Tab";
            this.keyboardButton_Tab.Location = new System.Drawing.Point(207, 145);
            this.keyboardButton_Tab.Name = "keyboardButton_Tab";
            this.keyboardButton_Tab.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_Tab.TabIndex = 29;
            this.keyboardButton_Tab.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.keyboardButton_TAB_Click);
            // 
            // keyboardButton_Enter
            // 
            this.keyboardButton_Enter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_Enter.KeyFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.keyboardButton_Enter.KeyValue = "确定";
            this.keyboardButton_Enter.Location = new System.Drawing.Point(143, 209);
            this.keyboardButton_Enter.Name = "keyboardButton_Enter";
            this.keyboardButton_Enter.Size = new System.Drawing.Size(122, 58);
            this.keyboardButton_Enter.TabIndex = 28;
            this.keyboardButton_Enter.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.keyboardButton_Enter_Click);
            // 
            // keyboardButton_Backspace
            // 
            this.keyboardButton_Backspace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_Backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_Backspace.KeyFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.keyboardButton_Backspace.KeyValue = "退格";
            this.keyboardButton_Backspace.Location = new System.Drawing.Point(207, 17);
            this.keyboardButton_Backspace.Name = "keyboardButton_Backspace";
            this.keyboardButton_Backspace.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_Backspace.TabIndex = 27;
            this.keyboardButton_Backspace.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.keyboardButton_Backspace_Click);
            // 
            // keyboardButton_0
            // 
            this.keyboardButton_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_0.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_0.KeyValue = "0";
            this.keyboardButton_0.Location = new System.Drawing.Point(15, 209);
            this.keyboardButton_0.Name = "keyboardButton_0";
            this.keyboardButton_0.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_0.TabIndex = 26;
            this.keyboardButton_0.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_9
            // 
            this.keyboardButton_9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_9.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_9.KeyValue = "9";
            this.keyboardButton_9.Location = new System.Drawing.Point(143, 17);
            this.keyboardButton_9.Name = "keyboardButton_9";
            this.keyboardButton_9.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_9.TabIndex = 25;
            this.keyboardButton_9.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_8
            // 
            this.keyboardButton_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_8.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_8.KeyValue = "8";
            this.keyboardButton_8.Location = new System.Drawing.Point(79, 17);
            this.keyboardButton_8.Name = "keyboardButton_8";
            this.keyboardButton_8.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_8.TabIndex = 24;
            this.keyboardButton_8.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_7
            // 
            this.keyboardButton_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_7.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_7.KeyValue = "7";
            this.keyboardButton_7.Location = new System.Drawing.Point(15, 17);
            this.keyboardButton_7.Name = "keyboardButton_7";
            this.keyboardButton_7.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_7.TabIndex = 23;
            this.keyboardButton_7.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_6
            // 
            this.keyboardButton_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_6.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_6.KeyValue = "6";
            this.keyboardButton_6.Location = new System.Drawing.Point(143, 81);
            this.keyboardButton_6.Name = "keyboardButton_6";
            this.keyboardButton_6.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_6.TabIndex = 22;
            this.keyboardButton_6.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_5
            // 
            this.keyboardButton_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_5.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_5.KeyValue = "5";
            this.keyboardButton_5.Location = new System.Drawing.Point(79, 81);
            this.keyboardButton_5.Name = "keyboardButton_5";
            this.keyboardButton_5.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_5.TabIndex = 21;
            this.keyboardButton_5.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_4
            // 
            this.keyboardButton_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_4.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_4.KeyValue = "4";
            this.keyboardButton_4.Location = new System.Drawing.Point(15, 81);
            this.keyboardButton_4.Name = "keyboardButton_4";
            this.keyboardButton_4.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_4.TabIndex = 20;
            this.keyboardButton_4.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_3
            // 
            this.keyboardButton_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_3.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_3.KeyValue = "3";
            this.keyboardButton_3.Location = new System.Drawing.Point(143, 145);
            this.keyboardButton_3.Name = "keyboardButton_3";
            this.keyboardButton_3.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_3.TabIndex = 19;
            this.keyboardButton_3.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_2
            // 
            this.keyboardButton_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_2.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_2.KeyValue = "2";
            this.keyboardButton_2.Location = new System.Drawing.Point(79, 145);
            this.keyboardButton_2.Name = "keyboardButton_2";
            this.keyboardButton_2.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_2.TabIndex = 18;
            this.keyboardButton_2.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // keyboardButton_1
            // 
            this.keyboardButton_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_1.KeyFont = new System.Drawing.Font("宋体", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_1.KeyValue = "1";
            this.keyboardButton_1.Location = new System.Drawing.Point(15, 145);
            this.keyboardButton_1.Name = "keyboardButton_1";
            this.keyboardButton_1.Size = new System.Drawing.Size(58, 58);
            this.keyboardButton_1.TabIndex = 17;
            this.keyboardButton_1.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.SendKeyValue);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.keyboardButton_Hide);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 38);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // keyboardButton_Hide
            // 
            this.keyboardButton_Hide.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.keyboardButton_Hide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyboardButton_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.keyboardButton_Hide.KeyFont = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyboardButton_Hide.KeyValue = "X";
            this.keyboardButton_Hide.Location = new System.Drawing.Point(235, 3);
            this.keyboardButton_Hide.Name = "keyboardButton_Hide";
            this.keyboardButton_Hide.Size = new System.Drawing.Size(38, 30);
            this.keyboardButton_Hide.TabIndex = 17;
            this.keyboardButton_Hide.KeyboardButtonClick += new SmartGunBulletManager.UI.UserControls.KeyboardButton.EventHandler(this.HideBody);
            // 
            // ScreenKeyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ScreenKeyboard";
            this.Size = new System.Drawing.Size(278, 318);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private KeyboardButton keyboardButton_Hide;
        private System.Windows.Forms.Panel panel2;
        private KeyboardButton keyboardButton_Clear;
        private KeyboardButton keyboardButton_Point;
        private KeyboardButton keyboardButton_Tab;
        private KeyboardButton keyboardButton_Enter;
        private KeyboardButton keyboardButton_Backspace;
        private KeyboardButton keyboardButton_0;
        private KeyboardButton keyboardButton_9;
        private KeyboardButton keyboardButton_8;
        private KeyboardButton keyboardButton_7;
        private KeyboardButton keyboardButton_6;
        private KeyboardButton keyboardButton_5;
        private KeyboardButton keyboardButton_4;
        private KeyboardButton keyboardButton_3;
        private KeyboardButton keyboardButton_2;
        private KeyboardButton keyboardButton_1;
    }
}
