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
    /// <summary>
    /// ヒント画面
    /// </summary>
    public partial class HintForm : Form {
        private AIQuestionProcessor FAiProcessor;

        public HintForm() {
            InitializeComponent();
            FAiProcessor = new AIQuestionProcessor();
        }

        private void QuestionSendButton_Click(object vSender, EventArgs e) {
            string wUserInputMessage = QuestionTextBox.Text.Trim();

            if (string.IsNullOrEmpty(wUserInputMessage)) {
                HintReplyLabel.Text = "質問を入力してね！";
                return;
            }

            //応答中に再度送信ボタンが押せないように無効化
            QuestionSendButton.Enabled = false;
            HintReplyLabel.Text = "考え中だよ…";

            try {
                string wAiResponse = FAiProcessor.GetAIResponse(wUserInputMessage);
                HintReplyLabel.Text = wAiResponse;
            } catch (Exception wEx) {
                MessageBox.Show("エラーが発生しました: " + wEx.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HintReplyLabel.Text = "エラーが発生しました。もう一度試してください。";
            } finally {
                // 送信ボタンを再度有効化
                QuestionSendButton.Enabled = true;
            }
        }

        private void QuestionBackButton_Click(object sender, EventArgs e) {
            CharacterMessageManager.SetRandomHintkunMessage();
            FormManager.ShowForm(new GamePlayForm());
        }
    }
}
