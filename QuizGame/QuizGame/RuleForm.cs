using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// ルール画面
    /// </summary>
    public partial class RuleForm : Form {
        /// <summary>
        /// ルール画面クラスのコンストラクタ
        /// </summary>
        public RuleForm() {
            InitializeComponent();
        }

        private void GameStartButton_Click(object sender, EventArgs e) {
            QuestionManager.SetRandomQuestion();
            CharacterMessageManager.SetInitialHintkunMessage();
            FormManager.ShowForm(new GamePlayForm());
        }
    }
}
