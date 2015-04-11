namespace SmartGunBulletManager.UI.UserControls
{
    partial class KeyboardButton
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
            this.label_KeyValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_KeyValue
            // 
            this.label_KeyValue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_KeyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_KeyValue.Font = new System.Drawing.Font("宋体", 12F);
            this.label_KeyValue.ForeColor = System.Drawing.Color.White;
            this.label_KeyValue.Location = new System.Drawing.Point(0, 0);
            this.label_KeyValue.Name = "label_KeyValue";
            this.label_KeyValue.Size = new System.Drawing.Size(58, 58);
            this.label_KeyValue.TabIndex = 0;
            this.label_KeyValue.Text = "1";
            this.label_KeyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_KeyValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_KeyValue_MouseDown);
            this.label_KeyValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_KeyValue_MouseUp);
            // 
            // KeyboardButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_KeyValue);
            this.Name = "KeyboardButton";
            this.Size = new System.Drawing.Size(58, 58);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_KeyValue;
    }
}
