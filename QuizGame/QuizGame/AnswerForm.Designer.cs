namespace QuizGame {
    partial class AnswerForm {
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
            this.AnswerExplanationLabel = new System.Windows.Forms.Label();
            this.AnswerPanel = new System.Windows.Forms.Panel();
            this.AnswerCharacterPicture = new System.Windows.Forms.PictureBox();
            this.CorrectButton = new System.Windows.Forms.Button();
            this.IncorrectButton = new System.Windows.Forms.Button();
            this.UserAnswerLabel = new System.Windows.Forms.Label();
            this.AnswerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerCharacterPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // AnswerExplanationLabel
            // 
            this.AnswerExplanationLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnswerExplanationLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerExplanationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AnswerExplanationLabel.Location = new System.Drawing.Point(0, 0);
            this.AnswerExplanationLabel.Name = "AnswerExplanationLabel";
            this.AnswerExplanationLabel.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.AnswerExplanationLabel.Size = new System.Drawing.Size(750, 240);
            this.AnswerExplanationLabel.TabIndex = 5;
            this.AnswerExplanationLabel.Text = "【解答】\r\n\r\n解答を表示\r\n\r\n\r\n【解説】\r\n\r\n解説を表示";
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.BackColor = System.Drawing.Color.White;
            this.AnswerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerPanel.Controls.Add(this.AnswerCharacterPicture);
            this.AnswerPanel.Controls.Add(this.CorrectButton);
            this.AnswerPanel.Controls.Add(this.IncorrectButton);
            this.AnswerPanel.Controls.Add(this.AnswerExplanationLabel);
            this.AnswerPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnswerPanel.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerPanel.Location = new System.Drawing.Point(18, 20);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.Size = new System.Drawing.Size(750, 300);
            this.AnswerPanel.TabIndex = 9;
            // 
            // AnswerCharacterPicture
            // 
            this.AnswerCharacterPicture.Image = global::QuizGame.Properties.Resources.tsunagetakunaru;
            this.AnswerCharacterPicture.Location = new System.Drawing.Point(658, 8);
            this.AnswerCharacterPicture.Name = "AnswerCharacterPicture";
            this.AnswerCharacterPicture.Size = new System.Drawing.Size(82, 135);
            this.AnswerCharacterPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnswerCharacterPicture.TabIndex = 15;
            this.AnswerCharacterPicture.TabStop = false;
            // 
            // CorrectButton
            // 
            this.CorrectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(80)))));
            this.CorrectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CorrectButton.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CorrectButton.ForeColor = System.Drawing.Color.White;
            this.CorrectButton.Location = new System.Drawing.Point(635, 240);
            this.CorrectButton.Name = "CorrectButton";
            this.CorrectButton.Size = new System.Drawing.Size(50, 50);
            this.CorrectButton.TabIndex = 14;
            this.CorrectButton.Text = "〇";
            this.CorrectButton.UseVisualStyleBackColor = false;
            this.CorrectButton.Click += new System.EventHandler(this.CorrectButton_Click);
            // 
            // IncorrectButton
            // 
            this.IncorrectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.IncorrectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncorrectButton.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IncorrectButton.ForeColor = System.Drawing.Color.White;
            this.IncorrectButton.Location = new System.Drawing.Point(690, 240);
            this.IncorrectButton.Name = "IncorrectButton";
            this.IncorrectButton.Size = new System.Drawing.Size(50, 50);
            this.IncorrectButton.TabIndex = 13;
            this.IncorrectButton.Text = "×";
            this.IncorrectButton.UseVisualStyleBackColor = false;
            this.IncorrectButton.Click += new System.EventHandler(this.IncorrectButton_Click);
            // 
            // UserAnswerLabel
            // 
            this.UserAnswerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UserAnswerLabel.BackColor = System.Drawing.Color.White;
            this.UserAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserAnswerLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UserAnswerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.UserAnswerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserAnswerLabel.Location = new System.Drawing.Point(20, 340);
            this.UserAnswerLabel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.UserAnswerLabel.Name = "UserAnswerLabel";
            this.UserAnswerLabel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.UserAnswerLabel.Size = new System.Drawing.Size(750, 50);
            this.UserAnswerLabel.TabIndex = 9;
            this.UserAnswerLabel.Text = "ユーザーの入力した答えを表示";
            this.UserAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.UserAnswerLabel);
            this.Controls.Add(this.AnswerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "AnswerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ときタクナル";
            this.AnswerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AnswerCharacterPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label AnswerExplanationLabel;
        private System.Windows.Forms.Panel AnswerPanel;
        private System.Windows.Forms.Label UserAnswerLabel;
        private System.Windows.Forms.Button IncorrectButton;
        private System.Windows.Forms.Button CorrectButton;
        private System.Windows.Forms.PictureBox AnswerCharacterPicture;
    }
}