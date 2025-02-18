namespace QuizGame {
    partial class ResultForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.HomeBackButton = new System.Windows.Forms.Button();
            this.ResultTitleLabel = new System.Windows.Forms.Label();
            this.FeedbackBubblePicture = new System.Windows.Forms.PictureBox();
            this.ResultValueLabel = new System.Windows.Forms.Label();
            this.FeedbackLabel = new System.Windows.Forms.Label();
            this.FeedbackCharacterPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackBubblePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackCharacterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBackButton
            // 
            this.HomeBackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HomeBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBackButton.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HomeBackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.HomeBackButton.Location = new System.Drawing.Point(318, 351);
            this.HomeBackButton.Name = "HomeBackButton";
            this.HomeBackButton.Size = new System.Drawing.Size(150, 40);
            this.HomeBackButton.TabIndex = 1;
            this.HomeBackButton.Text = "ホームに戻る";
            this.HomeBackButton.UseVisualStyleBackColor = true;
            this.HomeBackButton.Click += new System.EventHandler(this.HomeBackButton_Click);
            // 
            // ResultTitleLabel
            // 
            this.ResultTitleLabel.AutoSize = true;
            this.ResultTitleLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ResultTitleLabel.Location = new System.Drawing.Point(300, 50);
            this.ResultTitleLabel.Name = "ResultTitleLabel";
            this.ResultTitleLabel.Size = new System.Drawing.Size(216, 48);
            this.ResultTitleLabel.TabIndex = 2;
            this.ResultTitleLabel.Text = "最終結果\r\n";
            // 
            // FeedbackBubblePicture
            // 
            this.FeedbackBubblePicture.BackColor = System.Drawing.Color.Transparent;
            this.FeedbackBubblePicture.Image = ((System.Drawing.Image)(resources.GetObject("FeedbackBubblePicture.Image")));
            this.FeedbackBubblePicture.Location = new System.Drawing.Point(77, 188);
            this.FeedbackBubblePicture.Name = "FeedbackBubblePicture";
            this.FeedbackBubblePicture.Size = new System.Drawing.Size(522, 134);
            this.FeedbackBubblePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedbackBubblePicture.TabIndex = 6;
            this.FeedbackBubblePicture.TabStop = false;
            // 
            // ResultValueLabel
            // 
            this.ResultValueLabel.AutoSize = true;
            this.ResultValueLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ResultValueLabel.Location = new System.Drawing.Point(330, 110);
            this.ResultValueLabel.Name = "ResultValueLabel";
            this.ResultValueLabel.Size = new System.Drawing.Size(167, 48);
            this.ResultValueLabel.TabIndex = 8;
            this.ResultValueLabel.Text = "○○点";
            // 
            // FeedbackLabel
            // 
            this.FeedbackLabel.BackColor = System.Drawing.Color.White;
            this.FeedbackLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FeedbackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.FeedbackLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FeedbackLabel.Location = new System.Drawing.Point(107, 206);
            this.FeedbackLabel.Name = "FeedbackLabel";
            this.FeedbackLabel.Size = new System.Drawing.Size(430, 99);
            this.FeedbackLabel.TabIndex = 9;
            this.FeedbackLabel.Text = "遊んでくれてありがとう！";
            this.FeedbackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FeedbackCharacterPicture
            // 
            this.FeedbackCharacterPicture.BackColor = System.Drawing.Color.Transparent;
            this.FeedbackCharacterPicture.Image = global::QuizGame.Properties.Resources.Hirakitakunaru;
            this.FeedbackCharacterPicture.Location = new System.Drawing.Point(605, 167);
            this.FeedbackCharacterPicture.Name = "FeedbackCharacterPicture";
            this.FeedbackCharacterPicture.Size = new System.Drawing.Size(177, 175);
            this.FeedbackCharacterPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FeedbackCharacterPicture.TabIndex = 4;
            this.FeedbackCharacterPicture.TabStop = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.FeedbackLabel);
            this.Controls.Add(this.FeedbackBubblePicture);
            this.Controls.Add(this.ResultValueLabel);
            this.Controls.Add(this.FeedbackCharacterPicture);
            this.Controls.Add(this.ResultTitleLabel);
            this.Controls.Add(this.HomeBackButton);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ときタクナル";
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackBubblePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackCharacterPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HomeBackButton;
        private System.Windows.Forms.Label ResultTitleLabel;
        private System.Windows.Forms.PictureBox FeedbackBubblePicture;
        private System.Windows.Forms.Label ResultValueLabel;
        private System.Windows.Forms.Label FeedbackLabel;
        private System.Windows.Forms.PictureBox FeedbackCharacterPicture;
    }
}