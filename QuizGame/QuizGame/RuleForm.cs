using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// ルール画面
    /// </summary>
    public partial class RuleForm : Form {
        public RuleForm() {
            InitializeComponent();
        }

        private void GameStartButton_Click(object sender, EventArgs e) {
            QuestionManager.SetRandomQuestion();
            FormManager.ShowForm(new GamePlayForm());
        }
    }
}
