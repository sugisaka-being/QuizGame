using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 解答及び正誤判定画面
    /// </summary>
    public partial class AnswerForm : Form {
        /// <summary>
        /// 解答及び正誤判定画面
        /// </summary>
        /// <param name="vUserAnswerText">GamePlayFormでユーザーが入力した回答</param>
        public AnswerForm(string vUserAnswerText) {
            InitializeComponent();
            LoadAnswer();
            UserAnswerLabel.Text = vUserAnswerText;
        }

        /// <summary>
        /// 問題に応じた解答と解説を取得して表示するメソッド
        /// </summary>
        private void LoadAnswer() {
            AnswerExplanationLabel.Text = string.Format("【解答】{0}{0}{1}{0}{0}{0}【解説】{0}{0}{2}", 
                Environment.NewLine, QuestionManager.GetCurrentQuestion().Answer, QuestionManager.GetCurrentQuestion().Explanation);
        }

        private void CorrectButton_Click(object sender, EventArgs e) {
            QuestionManager.SetRandomQuestion(); //最終問題じゃない場合
            FormManager.ShowForm(new GamePlayForm()); //最終問題じゃない場合
            // FormManager.ShowForm(new ResultForm()); //最終問題の場合
            // 最終問題の場合は「QuestionManager.SetRandomQuestion();」の記述は丸々消す
        }

        private void IncorrectButton_Click(object sender, EventArgs e) {
            QuestionManager.SetRandomQuestion(); //最終問題じゃない場合
            FormManager.ShowForm(new GamePlayForm()); //最終問題じゃない場合
            // FormManager.ShowForm(new ResultForm()); //最終問題の場合
            // 最終問題の場合は「QuestionManager.SetRandomQuestion();」の記述は丸々消す
        }
    }
}
