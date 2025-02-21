using System;
using System.Drawing;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace QuizGame {
    /// <summary>
    /// 問題解答画面（プレイ画面）
    /// </summary>
    public partial class GamePlayForm : Form {
        private readonly string FInitialAnswerMessage = "ここに解答を入力してね！";
        private readonly string FEmptyAnswerMessage = "解答が入力されなかったよ！";

        /// <summary>
        /// 問題解答画面（プレイ画面）クラスのコンストラクタ
        /// </summary>
        public GamePlayForm() {
            InitializeComponent();
            LoadQuestion();
            UpdateScore();
            LoadHintkunMessage();
            SetInitialMessage(AnswerTextBox, FInitialAnswerMessage);
            AnswerTextBox.GotFocus += AnswerTextBox_GotFocus;
        }

        private void HintCharacterButton_Click(object sender, EventArgs e) {
            SoundManager.Instance.PlayGoHintSound();
            FormManager.ShowForm(new HintForm());
        }

        private void AnswerButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(AnswerTextBox.Text.Trim()) || AnswerTextBox.Text == FInitialAnswerMessage || AnswerTextBox.Text == FEmptyAnswerMessage) {
                SetInitialMessage(AnswerTextBox, FEmptyAnswerMessage);
                SoundManager.Instance.PlayClickSound();
            } else {
                SoundManager.Instance.PlayAnswerSound();
                FormManager.ShowForm(new AnswerForm(AnswerTextBox.Text));
            }
        }

        /// <summary>
        /// 任意のテキストボックスにメッセージを設定するメソッド（グレー色で設定）
        /// </summary>
        /// <param name="vTextBox">指定するテキストボックス</param>
        /// <param name="vMessage">指定するメッセージ</param>
        public static void SetInitialMessage(TextBox vTextBox, string vMessage) {
            vTextBox.ForeColor = Color.DarkGray;
            vTextBox.Text = vMessage;
        }

        /// <summary>
        /// 問題番号と問題文を取得して表示するメソッド
        /// </summary>
        private void LoadQuestion() {
            QuestionNumberLabel.Text = $"【第{GameManager.GetCurrentQuestionNumber()}問】";
            QuestionLabel.Text = QuestionManager.GetCurrentQuestion().QuestionText;
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
        /// 初期メッセージが表示されている状態でテキストボックスにフォーカスされた場合、内容をクリアする
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト（未使用）</param>
        /// <param name="e">イベントの引数（未使用）</param>
        private void AnswerTextBox_GotFocus(object sender, EventArgs e) {
            if (AnswerTextBox.Text == FInitialAnswerMessage || AnswerTextBox.Text == FEmptyAnswerMessage) {
                AnswerTextBox.Clear();
                AnswerTextBox.ForeColor = Color.FromArgb(60, 55, 55);
            }
        }
    }
}
