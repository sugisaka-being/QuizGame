using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 問題解答画面（プレイ画面）
    /// </summary>
    public partial class GamePlayForm : Form {
        public GamePlayForm() {
            InitializeComponent();
            LoadQuestion();
            UpdateScore();
        }

        private void HintCharacterButton_Click(object sender, EventArgs e) {
            FormManager.ShowForm(new HintForm());
        }

        private void AnswerButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(AnswerTextBox.Text.Trim())) {
                AnswerTextBox.Text = "解答が入力されなかったナル！";
            } else {
                FormManager.ShowForm(new AnswerForm(AnswerTextBox.Text));
            }
        }

        /// <summary>
        /// 最新の得点を表示するメソッド
        /// </summary>
        private void UpdateScore() {
            ScoreValueLabel.Text = GameManager.GetFormattedScore();
        }

        /// <summary>
        /// 問題文を取得して表示するメソッド
        /// </summary>
        private void LoadQuestion() {
            QuestionLabel.Text = QuestionManager.GetCurrentQuestion().QuestionText;
        }
    }
}
