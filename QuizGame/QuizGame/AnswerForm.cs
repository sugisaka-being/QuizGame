using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame {
    public partial class AnswerForm : Form {
        public AnswerForm() {
            InitializeComponent();
        }

        private void CorrectButton_Click(object sender, EventArgs e) {
            FormManager.ShowForm(new ResultForm()); //最終問題の場合
        }

        private void IncorrectButton_Click(object sender, EventArgs e) {
            FormManager.ShowForm(new ResultForm()); //最終問題の場合
        }
    }
}
