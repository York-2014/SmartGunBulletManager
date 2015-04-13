namespace SmartGunBulletManager.UI.UserControls
{
    partial class BlockButton
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
            this.label_Description = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.BackColor = System.Drawing.Color.Transparent;
            this.label_Description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Description.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_Description.Location = new System.Drawing.Point(32, 39);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(102, 22);
            this.label_Description.TabIndex = 0;
            this.label_Description.Text = "文字描述";
            this.label_Description.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BlockButton_MouseDown);
            this.label_Description.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BlockButton_MouseUp);
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Icon.Image = global::SmartGunBulletManager.Properties.Resources.find_32;
            this.pictureBox_Icon.Location = new System.Drawing.Point(176, 34);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Icon.TabIndex = 1;
            this.pictureBox_Icon.TabStop = false;
            this.pictureBox_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BlockButton_MouseDown);
            this.pictureBox_Icon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BlockButton_MouseUp);
            // 
            // BlockButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox_Icon);
            this.Controls.Add(this.label_Description);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BlockButton";
            this.Size = new System.Drawing.Size(238, 98);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BlockButton_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BlockButton_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
    }
}
