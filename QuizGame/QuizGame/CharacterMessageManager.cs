using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// キャラクターとそのメッセージを管理するクラス
    /// </summary>
    internal class CharacterMessageManager {
        private static readonly List<CharacterMessage> FAllHintkunMessages = new List<CharacterMessage> ();
        private static List<CharacterMessage> FRemainingHintkunMessages = new List<CharacterMessage>(FAllHintkunMessages);
        private static CharacterMessage FCurrentHintkunMessage;
        private static Random FRandom = new Random();
        private static bool FIsHintMessagesLoaded = false;


        /// <summary>
        /// キャラクターとそのメッセージを管理するクラスのコンストラクタ
        /// </summary>
        static CharacterMessageManager() {
            if (!FIsHintMessagesLoaded) {
                LoadHintkunMessagesFromResource();
                FIsHintMessagesLoaded = true;
            }
            SetInitialHintkunMessage();
        }

        /// <summary>
        /// リソースファイルからメッセージ情報を読み込み、メッセージを抽出してリストに格納する
        /// </summary>
        private static void LoadHintkunMessagesFromResource() {
            string wMessagesResourceName = "QuizGame.Resources.Messages.HintkunMessages.txt";
            Stream wMessagesResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wMessagesResourceName);

            if (wMessagesResourceStream == null) {
                MessageBox.Show("指定されたリソースが見つかりませんでした：" + wMessagesResourceName);
                return;
            }

            using (var wMessagesReader = new StreamReader(wMessagesResourceStream)) {
                string[] wMessageBlocks = wMessagesReader.ReadToEnd().Split(new string[] { "-----" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var wMessageBlock in wMessageBlocks) {
                    string wMessageText = wMessageBlock.Trim();
                    if (string.IsNullOrEmpty(wMessageText)) return;
                    FAllHintkunMessages.Add(new CharacterMessage(wMessageText));
                }

                FRemainingHintkunMessages = new List<CharacterMessage>(FAllHintkunMessages);
            }
        }

        /// <summary>
        /// ヒント君の初期値メッセージを設定するメソッド
        /// </summary>
        public static void SetInitialHintkunMessage() {
            FCurrentHintkunMessage = new CharacterMessage("困ったときは僕をクリックしてみて！！");
        }

        /// <summary>
        /// ランダムにヒント君メッセージを選択し、未表示リストから削除する（すべてのメッセージが表示されると未表示リストはリセットされる）
        /// </summary>
        public static void SetRandomHintkunMessage() {
            if (FRemainingHintkunMessages.Count == 0) {
                FRemainingHintkunMessages = new List<CharacterMessage>(FAllHintkunMessages);
            }
            int wHintkunMessagesIndex = FRandom.Next(FRemainingHintkunMessages.Count);
            FCurrentHintkunMessage = FRemainingHintkunMessages[wHintkunMessagesIndex];
            FRemainingHintkunMessages.RemoveAt(wHintkunMessagesIndex);
        }

        /// <summary>
        /// 現在のヒント君メッセージを取得する
        /// </summary>
        /// <returns>現在選択されているメッセージ</returns>
        public static CharacterMessage GetCurrentHintkunMessage() {
            return FCurrentHintkunMessage;
        }

        private static readonly Dictionary<int, string[]> FResultFeedbackMessages = new Dictionary<int, string[]>() {
            { 0, new string[] { "ナイスチャレンジ！" + Environment.NewLine + "君の挑戦が全ての始まり！", "失敗を恐れない君の姿勢は最高！次回が楽しみナル！" }},
            { 10, new string[] { "まずは10点！ここから" + Environment.NewLine + "君の成長が始まるよ！", "10点ゲット！小さな成功が未来を照らすよ！" }},
            { 20, new string[] { "確実に力を伸ばしてるね！半分まであと少しナル！", "その調子！次はさらに" + Environment.NewLine + "チャレンジしてみるナル！" }},
            { 30, new string[] { "30点！いい感じ！" + Environment.NewLine + "次はもっと自信を持って！", "全問正解が見えてきたね！君の実力が輝いてるナル！" }},
            { 40, new string[] { "40点はすごいよ！次回は" + Environment.NewLine + "全問正解を狙うナル！", "惜しかったね！あと少しで" + Environment.NewLine + "パーフェクトだ！" }},
            { 50, new string[] { "全問正解！君こそ真の" + Environment.NewLine + "クイズマスターナル！", "全制覇おめでとう！最高のパフォーマンスだね！" }}
        };

        /// <summary>
        /// スコアに応じたフィードバックコメントを取得するメソッド
        /// </summary>
        public static string GetResultComment(int vScore) {
            if (FResultFeedbackMessages.TryGetValue(vScore, out var wMessages)) {
                return wMessages[FRandom.Next(wMessages.Length)];
            }
            return "エラー：スコアがおかしいみたい...";
        }
    }
}
