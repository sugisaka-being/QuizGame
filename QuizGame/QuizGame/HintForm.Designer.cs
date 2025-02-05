namespace QuizGame {
    partial class HintForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HintForm));
            this.HintReplyLabel = new System.Windows.Forms.Label();
            this.QuestionBackButton = new System.Windows.Forms.Button();
            this.HintReplyBubblePicture = new System.Windows.Forms.PictureBox();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.QuestionSendButton = new System.Windows.Forms.Button();
            this.HintCharacterPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HintReplyBubblePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintCharacterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // HintReplyLabel
            // 
            this.HintReplyLabel.BackColor = System.Drawing.Color.White;
            this.HintReplyLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HintReplyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.HintReplyLabel.Location = new System.Drawing.Point(57, 63);
            this.HintReplyLabel.Name = "HintReplyLabel";
            this.HintReplyLabel.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.HintReplyLabel.Size = new System.Drawing.Size(456, 206);
            this.HintReplyLabel.TabIndex = 23;
            this.HintReplyLabel.Text = "ここに問題文を表示";
            // 
            // QuestionBackButton
            // 
            this.QuestionBackButton.BackColor = System.Drawing.Color.Turquoise;
            this.QuestionBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestionBackButton.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QuestionBackButton.ForeColor = System.Drawing.Color.Black;
            this.QuestionBackButton.Location = new System.Drawing.Point(689, 331);
            this.QuestionBackButton.Name = "QuestionBackButton";
            this.QuestionBackButton.Size = new System.Drawing.Size(75, 68);
            this.QuestionBackButton.TabIndex = 20;
            this.QuestionBackButton.Text = "問題に\r\n戻る\r\n";
            this.QuestionBackButton.UseVisualStyleBackColor = false;
            // 
            // HintReplyBubblePicture
            // 
            this.HintReplyBubblePicture.BackColor = System.Drawing.Color.Transparent;
            this.HintReplyBubblePicture.Image = ((System.Drawing.Image)(resources.GetObject("HintReplyBubblePicture.Image")));
            this.HintReplyBubblePicture.Location = new System.Drawing.Point(12, 12);
            this.HintReplyBubblePicture.Name = "HintReplyBubblePicture";
            this.HintReplyBubblePicture.Size = new System.Drawing.Size(581, 300);
            this.HintReplyBubblePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HintReplyBubblePicture.TabIndex = 22;
            this.HintReplyBubblePicture.TabStop = false;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionTextBox.Font = new System.Drawing.Font("游ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 329);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(581, 70);
            this.QuestionTextBox.TabIndex = 25;
            this.QuestionTextBox.Text = "日本の首都は？";
            // 
            // QuestionSendButton
            // 
            this.QuestionSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(195)))), ((int)(((byte)(230)))));
            this.QuestionSendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestionSendButton.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QuestionSendButton.Location = new System.Drawing.Point(599, 331);
            this.QuestionSendButton.Name = "QuestionSendButton";
            this.QuestionSendButton.Size = new System.Drawing.Size(84, 68);
            this.QuestionSendButton.TabIndex = 26;
            this.QuestionSendButton.Text = "質問！";
            this.QuestionSendButton.UseVisualStyleBackColor = false;
            this.QuestionSendButton.Click += new System.EventHandler(this.QuestionSendButton_Click);
            // 
            // HintCharacterPicture
            // 
            this.HintCharacterPicture.BackColor = System.Drawing.Color.Transparent;
            this.HintCharacterPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.HintCharacterPicture.Image = global::QuizGame.Properties.Resources.kangaetakunaru;
            this.HintCharacterPicture.Location = new System.Drawing.Point(599, 63);
            this.HintCharacterPicture.Name = "HintCharacterPicture";
            this.HintCharacterPicture.Size = new System.Drawing.Size(177, 230);
            this.HintCharacterPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HintCharacterPicture.TabIndex = 18;
            this.HintCharacterPicture.TabStop = false;
            // 
            // HintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.QuestionSendButton);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.HintReplyLabel);
            this.Controls.Add(this.QuestionBackButton);
            this.Controls.Add(this.HintReplyBubblePicture);
            this.Controls.Add(this.HintCharacterPicture);
            this.Name = "HintForm";
            this.Text = "ときタクナル";
            ((System.ComponentModel.ISupportInitialize)(this.HintReplyBubblePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintCharacterPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HintReplyLabel;
        private System.Windows.Forms.PictureBox HintReplyBubblePicture;
        private System.Windows.Forms.Button QuestionBackButton;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Button QuestionSendButton;
        private System.Windows.Forms.PictureBox HintCharacterPicture;
    }
}