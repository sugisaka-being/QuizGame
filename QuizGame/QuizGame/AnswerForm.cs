using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 解答及び正誤判定画面
    /// </summary>
    public partial class AnswerForm : Form {

        /// <summary>
        /// 解答及び正誤判定画面クラスのコンストラクタ
        /// </summary>
        /// <param name="vUserAnswerText">GamePlayFormでユーザーが入力した回答</param>
        public AnswerForm(string vUserAnswerText) {
            InitializeComponent();
            LoadAnswer();
            UserAnswerLabel.Text = vUserAnswerText;
        }

        private void CorrectButton_Click(object sender, EventArgs e) {
            GameManager.Score += 10;
            ProceedToNext();
        }

        private void IncorrectButton_Click(object sender, EventArgs e) {
            ProceedToNext();
        }

        /// <summary>
        /// 問題に応じた解答と解説を取得して表示するメソッド
        /// </summary>
        private void LoadAnswer() {
            AnswerExplanationLabel.Text = string.Format("【解答】{0}{0}{1}{0}{0}{0}【解説】{0}{0}{2}",
                Environment.NewLine, QuestionManager.GetCurrentQuestion().Answer, QuestionManager.GetCurrentQuestion().Explanation);
        }

        /// <summary>
        /// 次の画面に遷移するメソッド（現在の問題数が最大問題数と同じならResultFormに、それ以外なら次の問題を設定してGamePlayFormに遷移）
        /// </summary>
        private void ProceedToNext() {
            if (GameManager.CurrentQuestion == GameManager.C_MaxQuestions) {
                FormManager.ShowForm(new ResultForm());
            } else {
                GameManager.CurrentQuestion++;
                QuestionManager.SetRandomQuestion();
                CharacterMessageManager.SetRandomHintkunMessage();
                FormManager.ShowForm(new GamePlayForm());
            }
        }
    }
}
