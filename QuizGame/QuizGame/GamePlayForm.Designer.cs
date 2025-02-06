namespace QuizGame {
    partial class GamePlayForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlayForm));
            this.ScoreValueLabel = new System.Windows.Forms.Label();
            this.ScoreTitleLabel = new System.Windows.Forms.Label();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.HintMessageLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.AnswerButton = new System.Windows.Forms.Button();
            this.HintCharacterButton = new System.Windows.Forms.PictureBox();
            this.HintBubblePicture = new System.Windows.Forms.PictureBox();
            this.ScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HintCharacterButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintBubblePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreValueLabel
            // 
            this.ScoreValueLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScoreValueLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScoreValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.ScoreValueLabel.Location = new System.Drawing.Point(-1, 39);
            this.ScoreValueLabel.Name = "ScoreValueLabel";
            this.ScoreValueLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ScoreValueLabel.Size = new System.Drawing.Size(110, 40);
            this.ScoreValueLabel.TabIndex = 12;
            this.ScoreValueLabel.Text = "10点";
            this.ScoreValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScoreTitleLabel
            // 
            this.ScoreTitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScoreTitleLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScoreTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.ScoreTitleLabel.Location = new System.Drawing.Point(-1, -1);
            this.ScoreTitleLabel.Name = "ScoreTitleLabel";
            this.ScoreTitleLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ScoreTitleLabel.Size = new System.Drawing.Size(110, 40);
            this.ScoreTitleLabel.TabIndex = 13;
            this.ScoreTitleLabel.Text = "スコア";
            this.ScoreTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.White;
            this.ScorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScorePanel.Controls.Add(this.ScoreValueLabel);
            this.ScorePanel.Controls.Add(this.ScoreTitleLabel);
            this.ScorePanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScorePanel.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScorePanel.Location = new System.Drawing.Point(642, 30);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(110, 80);
            this.ScorePanel.TabIndex = 14;
            // 
            // HintMessageLabel
            // 
            this.HintMessageLabel.BackColor = System.Drawing.Color.White;
            this.HintMessageLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.HintMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.HintMessageLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HintMessageLabel.Location = new System.Drawing.Point(98, 221);
            this.HintMessageLabel.Name = "HintMessageLabel";
            this.HintMessageLabel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.HintMessageLabel.Size = new System.Drawing.Size(434, 63);
            this.HintMessageLabel.TabIndex = 18;
            this.HintMessageLabel.Text = "困った時は僕をクリックしてみて！！！\r\n\r\n";
            this.HintMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.BackColor = System.Drawing.Color.White;
            this.QuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.QuestionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.QuestionLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuestionLabel.Location = new System.Drawing.Point(25, 30);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.QuestionLabel.Size = new System.Drawing.Size(600, 150);
            this.QuestionLabel.TabIndex = 15;
            this.QuestionLabel.Text = "文字はプログラムで書く\r\n問題文を表示\r\n例：ある男が雨の中で歩いていたが、彼の髪は一切濡れていなかった。\r\nそれはいったいなぜ？\r\n\r\n";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerTextBox.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerTextBox.Location = new System.Drawing.Point(25, 339);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(620, 50);
            this.AnswerTextBox.TabIndex = 19;
            this.AnswerTextBox.Text = "ここに解答を入力してね";
            // 
            // AnswerButton
            // 
            this.AnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(195)))), ((int)(((byte)(230)))));
            this.AnswerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerButton.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AnswerButton.Location = new System.Drawing.Point(652, 339);
            this.AnswerButton.Name = "AnswerButton";
            this.AnswerButton.Size = new System.Drawing.Size(100, 50);
            this.AnswerButton.TabIndex = 20;
            this.AnswerButton.Text = " 解答！";
            this.AnswerButton.UseVisualStyleBackColor = false;
            this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
            // 
            // HintCharacterButton
            // 
            this.HintCharacterButton.BackColor = System.Drawing.Color.Transparent;
            this.HintCharacterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HintCharacterButton.Image = global::QuizGame.Properties.Resources.kangaetakunaru;
            this.HintCharacterButton.Location = new System.Drawing.Point(626, 149);
            this.HintCharacterButton.Name = "HintCharacterButton";
            this.HintCharacterButton.Size = new System.Drawing.Size(157, 195);
            this.HintCharacterButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HintCharacterButton.TabIndex = 17;
            this.HintCharacterButton.TabStop = false;
            this.HintCharacterButton.Click += new System.EventHandler(this.HintCharacterButton_Click);
            // 
            // HintBubblePicture
            // 
            this.HintBubblePicture.BackColor = System.Drawing.Color.Transparent;
            this.HintBubblePicture.Image = ((System.Drawing.Image)(resources.GetObject("HintBubblePicture.Image")));
            this.HintBubblePicture.Location = new System.Drawing.Point(25, 195);
            this.HintBubblePicture.Name = "HintBubblePicture";
            this.HintBubblePicture.Size = new System.Drawing.Size(600, 130);
            this.HintBubblePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HintBubblePicture.TabIndex = 17;
            this.HintBubblePicture.TabStop = false;
            // 
            // GamePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.AnswerButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.HintCharacterButton);
            this.Controls.Add(this.HintMessageLabel);
            this.Controls.Add(this.HintBubblePicture);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ScorePanel);
            this.Name = "GamePlayForm";
            this.Text = "ときタクナル";
            this.ScorePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HintCharacterButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintBubblePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ScoreValueLabel;
        private System.Windows.Forms.Label ScoreTitleLabel;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.PictureBox HintBubblePicture;
        private System.Windows.Forms.Label HintMessageLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.PictureBox HintCharacterButton;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button AnswerButton;
    }
}