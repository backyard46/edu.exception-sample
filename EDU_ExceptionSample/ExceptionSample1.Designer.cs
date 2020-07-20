namespace EDU_ExceptionSample
{
    partial class ExceptionSample1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DivByZeroButton = new System.Windows.Forms.Button();
            this.MessageLog = new System.Windows.Forms.TextBox();
            this.DivByZeroButtonNew = new System.Windows.Forms.Button();
            this.ShowSubFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DivByZeroButton
            // 
            this.DivByZeroButton.Location = new System.Drawing.Point(13, 106);
            this.DivByZeroButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DivByZeroButton.Name = "DivByZeroButton";
            this.DivByZeroButton.Size = new System.Drawing.Size(138, 39);
            this.DivByZeroButton.TabIndex = 0;
            this.DivByZeroButton.Text = "ゼロで割り算";
            this.DivByZeroButton.UseVisualStyleBackColor = true;
            this.DivByZeroButton.Click += new System.EventHandler(this.DivByZeroButton_Click);
            // 
            // MessageLog
            // 
            this.MessageLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageLog.Location = new System.Drawing.Point(12, 12);
            this.MessageLog.Multiline = true;
            this.MessageLog.Name = "MessageLog";
            this.MessageLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MessageLog.Size = new System.Drawing.Size(927, 87);
            this.MessageLog.TabIndex = 1;
            // 
            // DivByZeroButtonNew
            // 
            this.DivByZeroButtonNew.Location = new System.Drawing.Point(13, 153);
            this.DivByZeroButtonNew.Margin = new System.Windows.Forms.Padding(4);
            this.DivByZeroButtonNew.Name = "DivByZeroButtonNew";
            this.DivByZeroButtonNew.Size = new System.Drawing.Size(138, 39);
            this.DivByZeroButtonNew.TabIndex = 2;
            this.DivByZeroButtonNew.Text = "ゼロで割り算 改";
            this.DivByZeroButtonNew.UseVisualStyleBackColor = true;
            this.DivByZeroButtonNew.Click += new System.EventHandler(this.DivByZeroButtonNew_Click);
            // 
            // ShowSubFormButton
            // 
            this.ShowSubFormButton.Location = new System.Drawing.Point(185, 106);
            this.ShowSubFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowSubFormButton.Name = "ShowSubFormButton";
            this.ShowSubFormButton.Size = new System.Drawing.Size(138, 39);
            this.ShowSubFormButton.TabIndex = 3;
            this.ShowSubFormButton.Text = "子フォーム表示";
            this.ShowSubFormButton.UseVisualStyleBackColor = true;
            this.ShowSubFormButton.Click += new System.EventHandler(this.ShowSubFormButton_Click);
            // 
            // ExceptionSample1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 314);
            this.Controls.Add(this.ShowSubFormButton);
            this.Controls.Add(this.DivByZeroButtonNew);
            this.Controls.Add(this.MessageLog);
            this.Controls.Add(this.DivByZeroButton);
            this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExceptionSample1";
            this.Text = "ExceptionSample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DivByZeroButton;
        private System.Windows.Forms.TextBox MessageLog;
        private System.Windows.Forms.Button DivByZeroButtonNew;
        private System.Windows.Forms.Button ShowSubFormButton;
    }
}

