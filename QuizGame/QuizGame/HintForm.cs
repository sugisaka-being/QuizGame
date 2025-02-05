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
    public partial class HintForm : Form {
        private AIQuestionProcessor FAiProcessor;

        public HintForm() {
            InitializeComponent();
            FAiProcessor = new AIQuestionProcessor();
        }

        private void QuestionSendButton_Click(object vSender, EventArgs e) {
            string wUserInput = QuestionTextBox.Text.Trim();

            if (string.IsNullOrEmpty(wUserInput)) {
                HintReplyLabel.Text = "質問を入力してね！";
                return;

                /* メッセージボックスにエラーを表示させる場合
                MessageBox.Show("質問を入力してね！", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                */
            }

            QuestionSendButton.Enabled = false;
            HintReplyLabel.Text = "考え中だよ…";

            try {
                // AI からのヒントを取得
                string wAiResponse = FAiProcessor.GetAIResponse(wUserInput);

                // ラベルにヒントを表示
                HintReplyLabel.Text = wAiResponse;
            } catch (Exception wEx) {
                MessageBox.Show("エラーが発生しました: " + wEx.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HintReplyLabel.Text = "エラーが発生しました。もう一度試してください。";
            } finally {
                // 送信ボタンを再度有効化
                QuestionSendButton.Enabled = true;
            }
        }

    }
}
