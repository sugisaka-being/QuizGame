using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 問題解答画面（プレイ画面）
    /// </summary>
    public partial class GamePlayForm : Form {
        /// <summary>
        /// 問題解答画面（プレイ画面）クラスのコンストラクタ
        /// </summary>
        public GamePlayForm() {
            InitializeComponent();
            LoadQuestion();
            UpdateScore();
            LoadHintkunMessage();
        }
        
        private void HintCharacterButton_Click(object sender, EventArgs e) {
            SoundManager.Instance.PlayGoHintSound();
            FormManager.ShowForm(new HintForm());
        }

        private void AnswerButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(AnswerTextBox.Text.Trim())) {
                AnswerTextBox.Text = "解答が入力されなかったナル！";
                SoundManager.Instance.PlayClickSound();
            } else {
                SoundManager.Instance.PlayAnswerSound();
                FormManager.ShowForm(new AnswerForm(AnswerTextBox.Text));
            }
        }

        /// <summary>
        /// ヒント君メッセージを取得して表示するメソッド
        /// </summary>
        private void LoadHintkunMessage() {
            HintMessageLabel.Text = CharacterMessageManager.GetCurrentHintkunMessage().HintkunMessage;
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
