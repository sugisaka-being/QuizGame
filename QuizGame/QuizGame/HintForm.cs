using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuizGame {
    /// <summary>
    /// ヒント画面
    /// </summary>
    public partial class HintForm : Form {
        private readonly string FInitialQuestionMessage = "ここに質問を入力してね！" + Environment.NewLine + "(例：世界で一番広い国はどこ？)";
        private AIQuestionProcessor FAiProcessor;

        /// <summary>
        /// ヒント画面クラスのコンストラクタ
        /// </summary>
        public HintForm() {
            InitializeComponent();
            FAiProcessor = new AIQuestionProcessor();
            GamePlayForm.SetInitialMessage(QuestionTextBox, FInitialQuestionMessage);
            QuestionTextBox.GotFocus += QuestionTextBox_GotFocus;
        }

        private void QuestionSendButton_Click(object vSender, EventArgs e) {
            SoundManager.Instance.PlayAnswerSound();
            string wUserInputMessage = QuestionTextBox.Text.Trim();

            if (string.IsNullOrEmpty(wUserInputMessage) || QuestionTextBox.Text == FInitialQuestionMessage) {
                SoundManager.Instance.PlayClickSound();
                HintReplyLabel.Text = "質問を入力してね！";
                GamePlayForm.SetInitialMessage(QuestionTextBox, FInitialQuestionMessage);
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

        /// <summary>
        /// 初期メッセージが表示されている状態でテキストボックスにフォーカスされた場合、内容をクリアする
        /// </summary>
        /// <param name="sender">イベントを発生させたオブジェクト（未使用）</param>
        /// <param name="e">イベントの引数（未使用）</param>
        private void QuestionTextBox_GotFocus(object sender, EventArgs e) {
            if (QuestionTextBox.Text == FInitialQuestionMessage) {
                QuestionTextBox.Clear();
                QuestionTextBox.ForeColor = Color.FromArgb(60, 55, 55);
            }
        }
    }
}
