namespace QuizGame {
    partial class RuleForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleForm));
            this.RulesPanel = new System.Windows.Forms.Panel();
            this.GameStartButton = new System.Windows.Forms.Button();
            this.RulesDescriptionLabel = new System.Windows.Forms.Label();
            this.RulesTitleLabel = new System.Windows.Forms.Label();
            this.RulesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RulesPanel
            // 
            this.RulesPanel.BackColor = System.Drawing.Color.White;
            this.RulesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RulesPanel.Controls.Add(this.GameStartButton);
            this.RulesPanel.Controls.Add(this.RulesDescriptionLabel);
            this.RulesPanel.Controls.Add(this.RulesTitleLabel);
            this.RulesPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RulesPanel.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RulesPanel.Location = new System.Drawing.Point(40, 30);
            this.RulesPanel.Name = "RulesPanel";
            this.RulesPanel.Size = new System.Drawing.Size(700, 350);
            this.RulesPanel.TabIndex = 0;
            // 
            // GameStartButton
            // 
            this.GameStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameStartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.GameStartButton.FlatAppearance.BorderSize = 2;
            this.GameStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameStartButton.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameStartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.GameStartButton.Location = new System.Drawing.Point(280, 305);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(150, 30);
            this.GameStartButton.TabIndex = 2;
            this.GameStartButton.Text = "ゲーム開始";
            this.GameStartButton.UseVisualStyleBackColor = true;
            this.GameStartButton.Click += new System.EventHandler(this.GameStartButton_Click);
            // 
            // RulesDescriptionLabel
            // 
            this.RulesDescriptionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RulesDescriptionLabel.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RulesDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RulesDescriptionLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RulesDescriptionLabel.Location = new System.Drawing.Point(-1, 50);
            this.RulesDescriptionLabel.Name = "RulesDescriptionLabel";
            this.RulesDescriptionLabel.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.RulesDescriptionLabel.Size = new System.Drawing.Size(700, 250);
            this.RulesDescriptionLabel.TabIndex = 1;
            this.RulesDescriptionLabel.Text = resources.GetString("RulesDescriptionLabel.Text");
            // 
            // RulesTitleLabel
            // 
            this.RulesTitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.RulesTitleLabel.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RulesTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RulesTitleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RulesTitleLabel.Location = new System.Drawing.Point(-1, 0);
            this.RulesTitleLabel.Name = "RulesTitleLabel";
            this.RulesTitleLabel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.RulesTitleLabel.Size = new System.Drawing.Size(700, 40);
            this.RulesTitleLabel.TabIndex = 0;
            this.RulesTitleLabel.Text = "ルール説明";
            this.RulesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.RulesPanel);
            this.Name = "RuleForm";
            this.Text = "ときタクナル";
            this.RulesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RulesPanel;
        private System.Windows.Forms.Label RulesTitleLabel;
        private System.Windows.Forms.Label RulesDescriptionLabel;
        private System.Windows.Forms.Button GameStartButton;
    }
}