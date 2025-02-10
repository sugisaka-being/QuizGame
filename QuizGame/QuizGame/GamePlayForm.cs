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
            LoadHintkunMessage();
        }

        /// <summary>
        /// 問題文を取得して表示するメソッド
        /// </summary>
        private void LoadQuestion() {
            QuestionLabel.Text = QuestionManager.GetCurrentQuestion().QuestionText;
        }

        /// <summary>
        /// ヒント君メッセージを取得して表示する
        /// </summary>
        private void LoadHintkunMessage() {
            HintMessageLabel.Text = CharacterMessageManager.GetCurrentHintkunMessage().HintkunMessage;
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
    }
}
