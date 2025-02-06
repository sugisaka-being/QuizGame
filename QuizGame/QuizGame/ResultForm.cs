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
    /// 最終結果画面
    /// </summary>
    public partial class ResultForm : Form {

        private int FScore;
        private Random FRandom = new Random();

        /// <summary>
        ///  //本来はResultForm(int vScore)として得点を受け取るのがよいと思う
        /// </summary>
        public ResultForm() {
            InitializeComponent();

            //FScore = vScore; 　本来はここでスコアをFScoreに代入する
            FScore = 30;
            DisplayResultComment();
        }

        private void HomeBackButton_Click(object sender, EventArgs e) {
            FormManager.ShowForm(new StartForm());
        }

        /// <summary>
        /// スコアに応じたフィードバックコメントを表示するメソッド
        /// </summary>
        private void DisplayResultComment() {
            var wCommentPatterns = new Dictionary<int, string[]>()
            {
                { 0,  new string[] { "ナイスチャレンジ！" + Environment.NewLine + "君の挑戦が全ての始まり！", "失敗を恐れない君の姿勢は最高！次回が楽しみナル！" } },
                { 10, new string[] { "まずは10点！ここから" + Environment.NewLine + "君の成長が始まるよ！", "10点ゲット！小さな成功が未来を照らすよ！" } },
                { 20, new string[] { "確実に力を伸ばしてるね！半分まであと少しナル！", "その調子！次はさらに" + Environment.NewLine + "チャレンジしてみるナル！" } },
                { 30, new string[] { "30点！いい感じ！" + Environment.NewLine + "次はもっと自信を持って！", "全問正解が見えてきたね！君の実力が輝いてるナル！" } },
                { 40, new string[] { "40点はすごいよ！次回は" + Environment.NewLine + "全問正解を狙うナル！", "惜しかったね！あと少しで" + Environment.NewLine + "パーフェクトだ！" } },
                { 50, new string[] { "全問正解！君こそ真の" + Environment.NewLine + "クイズマスターナル！", "全制覇おめでとう！最高のパフォーマンスだね！" } }
            };

            // 渡されたスコアに対応するコメントをランダムで選択
            if (wCommentPatterns.ContainsKey(FScore)) {
                string[] wComments = wCommentPatterns[FScore];
                string wSelectedComment = wComments[FRandom.Next(wComments.Length)];
                FeedbackLabel.Text = wSelectedComment;
            } else {
                FeedbackLabel.Text = "エラー：スコアがおかしいみたい...";
            }
        }
    }
}





