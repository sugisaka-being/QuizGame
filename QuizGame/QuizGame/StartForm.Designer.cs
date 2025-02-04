namespace QuizGame {
    partial class StartForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.StartButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.White;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("游ゴシック Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.StartButton.Location = new System.Drawing.Point(290, 250);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 50);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "ゲームスタート";
            this.StartButton.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TitleLabel.Location = new System.Drawing.Point(185, 135);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(411, 64);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "ときタクナル";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.StartButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StartForm";
            this.Text = "ときタクナル";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TitleLabel;
    }
}

