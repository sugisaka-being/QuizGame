using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 最終結果画面
    /// </summary>
    public partial class ResultForm : Form {

        private int FResultScore = GameManager.Score;
        private Random FRandomMassage = new Random();

        /// <summary>
        /// 最終結果画面クラスのコンストラクタ
        /// </summary>
        public ResultForm() {
            InitializeComponent();
            UpdateScore();
            DisplayResultComment();
            SoundManager.Instance.PlayResultSound();
        }

        private void HomeBackButton_Click(object sender, EventArgs e) {
<<<<<<< HEAD
            BGMManager.PlayBGM("GameStartBGM.mp3");
=======
            SoundManager.Instance.PlayClickSound();
            BGMManager.PlayBGM("バウンドジャングル.mp3");
>>>>>>> develop
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
        /// スコアに応じたフィードバックコメントを表示させ、BGMを再生するメソッド
        private void DisplayResultComment() {
            var wResultDatas = new Dictionary<int, (string[], string)>() {
                { 0,  (new string[] { "ナイスチャレンジ！" + Environment.NewLine + "君の挑戦が全ての始まり！", "失敗を恐れない君の姿勢は最高！次回が楽しみナル！" }, "ZeroPointBGM.mp3") },
                { 10, (new string[] { "まずは10点！ここから" + Environment.NewLine + "君の成長が始まるよ！", "10点ゲット！小さな成功が未来を照らすよ！" }, "TenPointBGM.mp3") },
                { 20, (new string[] { "確実に力を伸ばしてるね！半分まであと少しナル！", "その調子！次はさらに" + Environment.NewLine + "チャレンジしてみるナル！" }, "TwentyPointBGM.mp3") },
                { 30, (new string[] { "30点！いい感じ！" + Environment.NewLine + "次はもっと自信を持って！", "全問正解が見えてきたね！君の実力が輝いてるナル！" }, "ThirtyPointBGM.mp3") },
                { 40, (new string[] { "40点はすごいよ！次回は" + Environment.NewLine + "全問正解を狙うナル！", "惜しかったね！あと少しで" + Environment.NewLine + "パーフェクトだ！" }, "FortyPointBGM.mp3") },
                { 50, (new string[] { "全問正解！君こそ真の" + Environment.NewLine + "クイズマスターナル！", "全制覇おめでとう！最高のパフォーマンスだね！" }, "FiftyPointBGM.mp3") }
            };

            // 渡されたスコアに対応するコメントをランダムで選択して表示
            // 渡されたスコアに対応するBGMを再生
            if (wResultDatas.TryGetValue(FResultScore, out var wResultData)) {
                var (wComments, wBGM) = wResultData;
                FeedbackLabel.Text = wComments[FRandomMassage.Next(wComments.Length)];
                BGMManager.PlayBGM(wBGM);
            } else {
                FeedbackLabel.Text = "エラー：スコアがおかしいみたい...";
            }
        }
    }
}





