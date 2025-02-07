using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 解答及び正誤判定画面
    /// </summary>
    public partial class AnswerForm : Form {
        public AnswerForm(string vUserAnswerText) {
            InitializeComponent();
            UserAnswerLabel.Text = vUserAnswerText;
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
