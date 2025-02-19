using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 最終結果画面
    /// </summary>
    public partial class ResultForm : Form {

        private int FResultScore = GameManager.Score;
        private Random FRandomMessage = new Random();

        /// <summary>
        /// 最終結果画面クラスのコンストラクタ
        /// </summary>
        public ResultForm() {
            InitializeComponent();
            UpdateScore();
            DisplayResultComment();
            PlayResultSoundAsync();
            // 効果音の再生終了後にBGMを再生するイベントを登録
            SoundManager.Instance.ResultSoundPlaybackCompleted += (sender, args) => {
                PlayResultBGM();
                HomeBackButton.Enabled = true;
            };
        }

        private  void HomeBackButton_Click(object sender, EventArgs e) {
            BGMManager.PlayBGM("GameStartBGM.mp3");
            SoundManager.Instance.PlayClickSound();
            GameManager.ResetGame();
            FormManager.ShowForm(new StartForm());
        }

        /// <summary>
        /// 最新の得点を表示するメソッド
        /// </summary>
        private void UpdateScore() {
            ResultValueLabel.Text = GameManager.GetFormattedScore();
        }

        /// <summary>
        /// スコアに応じたフィードバックコメントを表示するメソッド
        /// </summary>
        private void DisplayResultComment() {
            var wResultFeedBackDatas = new Dictionary<int, string[]>()
            {
                { 0, new string[] { "ナイスチャレンジ！" + Environment.NewLine + "君の挑戦が全ての始まり！", "失敗を恐れない君の姿勢は最高！次回が楽しみナル！" }},
                { 10, new string[] { "まずは10点！ここから" + Environment.NewLine + "君の成長が始まるよ！", "10点ゲット！小さな成功が未来を照らすよ！" }},
                { 20, new string[] { "確実に力を伸ばしてるね！半分まであと少しナル！", "その調子！次はさらに" + Environment.NewLine + "チャレンジしてみるナル！" }},
                { 30, new string[] { "30点！いい感じ！" + Environment.NewLine + "次はもっと自信を持って！", "全問正解が見えてきたね！君の実力が輝いてるナル！" }},
                { 40, new string[] { "40点はすごいよ！次回は" + Environment.NewLine + "全問正解を狙うナル！", "惜しかったね！あと少しで" + Environment.NewLine + "パーフェクトだ！" }},
                { 50, new string[] { "全問正解！君こそ真の" + Environment.NewLine + "クイズマスターナル！", "全制覇おめでとう！最高のパフォーマンスだね！" }}
            };

            if (wResultFeedBackDatas.TryGetValue(FResultScore, out var wResultData)) {
                FeedbackLabel.Text = wResultData[FRandomMessage.Next(wResultData.Length)];
            } else {
                FeedbackLabel.Text = "エラー：スコアがおかしいみたい...";
            }
        }

        /// <summary>
        /// 効果音を非同期に再生するメソッド
        /// </summary>
        private async void PlayResultSoundAsync() {
            await SoundManager.Instance.PlayResultSoundWithEvent();
        }

        /// <summary>
        /// スコアに応じたBGMを再生するメソッド
        /// <summary>
        private void PlayResultBGM() {
            var wResultBGMDatas = new Dictionary<int, string>()
           {
                { 0, "ZeroPointBGM.mp3" },
                { 10, "TenPointBGM.mp3" },
                { 20, "TwentyPointBGM.mp3" },
                { 30, "ThirtyPointBGM.mp3" },
                { 40, "FortyPointBGM.mp3" },
                { 50, "FiftyPointBGM.mp3" }
            };

            if (wResultBGMDatas.TryGetValue(FResultScore, out var wBGM)) {
                BGMManager.PlayBGM(wBGM);
            } else {
                FeedbackLabel.Text = "エラー：スコアがおかしいみたい...";
            }
        }
    }
}





