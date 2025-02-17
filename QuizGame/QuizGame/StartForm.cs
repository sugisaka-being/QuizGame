using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// スタート画面
    /// </summary>
    public partial class StartForm : Form {

        /// <summary>
        /// スタート画面クラスのコンストラクタ
        /// </summary>
        public StartForm() {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e) {
            SoundManager.Instance.PlayClickSound();
            Application.OpenForms[0].Hide();
            FormManager.ShowForm(new RuleForm());
        }
    }
}
