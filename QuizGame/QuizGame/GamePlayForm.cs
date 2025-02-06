using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame {
    public partial class GamePlayForm : Form {
        public GamePlayForm() {
            InitializeComponent();
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
