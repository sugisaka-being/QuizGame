using System;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 最終結果画面
    /// </summary>
    public partial class ResultForm : Form {
        private int FResultScore = GameManager.Score;

        /// <summary>
        /// 最終結果画面クラスのコンストラクタ
        /// </summary>
        public ResultForm() {
            InitializeComponent();
            FeedbackLabel.Text = CharacterMessageManager.GetResultComment(FResultScore);
            ResultValueLabel.Text = GameManager.GetFormattedScore();

            _ = SoundManager.Instance.PlayResultSoundAsync();
            // 効果音の再生終了後にBGMを再生するイベントを登録
            SoundManager.Instance.ResultSoundPlaybackCompleted += (sender, args) => {
                BGMManager.PlayResultBGM(FResultScore);
                HomeBackButton.Enabled = true;
            };
        }

        private void HomeBackButton_Click(object sender, EventArgs e) {
            BGMManager.PlayBGM("GameStartBGM.mp3");
            SoundManager.Instance.PlayClickSound();
            GameManager.ResetGame();
            FormManager.ShowForm(new StartForm());
        }
    }
}





