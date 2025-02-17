using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// ヒント画面
    /// </summary>
    public partial class HintForm : Form {

        private AIQuestionProcessor FAiProcessor;

        /// <summary>
        /// ヒント画面クラスのコンストラクタ
        /// </summary>
        public HintForm() {
            InitializeComponent();
            FAiProcessor = new AIQuestionProcessor();
        }

        private void QuestionSendButton_Click(object vSender, EventArgs e) {
            SoundManager.Instance.PlayAnswerSound();
            string wUserInputMessage = QuestionTextBox.Text.Trim();

            if (string.IsNullOrEmpty(wUserInputMessage)) {
                SoundManager.Instance.PlayClickSound();
                HintReplyLabel.Text = "質問を入力してね！";
                QuestionTextBox.Text = "ここに質問を入力してね！\r\n(例：世界で一番広い国はどこ？)\r\n";
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
            SoundManager.Instance.PlayReturnSound();
            CharacterMessageManager.SetRandomHintkunMessage();
            FormManager.ShowForm(new GamePlayForm());
        }
    }
}
