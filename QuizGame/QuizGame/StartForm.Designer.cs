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
            this.StartCharacterBottomRight = new System.Windows.Forms.PictureBox();
            this.StartCharacterBottomLeft = new System.Windows.Forms.PictureBox();
            this.StartCharacterTopRight = new System.Windows.Forms.PictureBox();
            this.StartCharacterTopLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartCharacterBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCharacterBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCharacterTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCharacterTopLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.White;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.StartButton.FlatAppearance.BorderSize = 2;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.StartButton.Location = new System.Drawing.Point(290, 260);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 50);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "ゲームスタート";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TitleLabel.Location = new System.Drawing.Point(-8, 125);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(800, 64);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "ときタクナル";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartCharacterBottomRight
            // 
            this.StartCharacterBottomRight.BackColor = System.Drawing.Color.Transparent;
            this.StartCharacterBottomRight.Image = global::QuizGame.Properties.Resources.kawaritakunaru;
            this.StartCharacterBottomRight.Location = new System.Drawing.Point(555, 217);
            this.StartCharacterBottomRight.Name = "StartCharacterBottomRight";
            this.StartCharacterBottomRight.Size = new System.Drawing.Size(116, 170);
            this.StartCharacterBottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartCharacterBottomRight.TabIndex = 5;
            this.StartCharacterBottomRight.TabStop = false;
            // 
            // StartCharacterBottomLeft
            // 
            this.StartCharacterBottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.StartCharacterBottomLeft.Image = global::QuizGame.Properties.Resources.Hirakitakunaru;
            this.StartCharacterBottomLeft.Location = new System.Drawing.Point(3, 210);
            this.StartCharacterBottomLeft.Name = "StartCharacterBottomLeft";
            this.StartCharacterBottomLeft.Size = new System.Drawing.Size(161, 194);
            this.StartCharacterBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartCharacterBottomLeft.TabIndex = 4;
            this.StartCharacterBottomLeft.TabStop = false;
            // 
            // StartCharacterTopRight
            // 
            this.StartCharacterTopRight.BackColor = System.Drawing.Color.Transparent;
            this.StartCharacterTopRight.Image = global::QuizGame.Properties.Resources.kangaetakunaru;
            this.StartCharacterTopRight.Location = new System.Drawing.Point(606, 2);
            this.StartCharacterTopRight.Name = "StartCharacterTopRight";
            this.StartCharacterTopRight.Size = new System.Drawing.Size(166, 221);
            this.StartCharacterTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartCharacterTopRight.TabIndex = 3;
            this.StartCharacterTopRight.TabStop = false;
            // 
            // StartCharacterTopLeft
            // 
            this.StartCharacterTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.StartCharacterTopLeft.Image = global::QuizGame.Properties.Resources.tsunagetakunaru;
            this.StartCharacterTopLeft.Location = new System.Drawing.Point(81, 25);
            this.StartCharacterTopLeft.Name = "StartCharacterTopLeft";
            this.StartCharacterTopLeft.Size = new System.Drawing.Size(99, 165);
            this.StartCharacterTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartCharacterTopLeft.TabIndex = 2;
            this.StartCharacterTopLeft.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.StartCharacterBottomRight);
            this.Controls.Add(this.StartCharacterBottomLeft);
            this.Controls.Add(this.StartCharacterTopRight);
            this.Controls.Add(this.StartCharacterTopLeft);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.StartButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ときタクナル";
            ((System.ComponentModel.ISupportInitialize)(this.StartCharacterBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCharacterBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCharacterTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartCharacterTopLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox StartCharacterTopLeft;
        private System.Windows.Forms.PictureBox StartCharacterTopRight;
        private System.Windows.Forms.PictureBox StartCharacterBottomLeft;
        private System.Windows.Forms.PictureBox StartCharacterBottomRight;
    }
}

