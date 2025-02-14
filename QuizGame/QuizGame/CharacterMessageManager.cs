using System;
using System.Collections.Generic;

namespace QuizGame {
    /// <summary>
    /// キャラクターとそのメッセージを管理するクラス
    /// </summary>
    internal class CharacterMessageManager {
        private static readonly List<CharacterMessage> FAllHintkunMessages = new List<CharacterMessage> {
            new CharacterMessage("この問題はむずかしいなぁ..."),
            new CharacterMessage("最後まで一緒にがんばろうね！"),
            new CharacterMessage("2人で協力すれば解けるかも！？"),
            new CharacterMessage("この問題はひとひねり必要そうだね！"),
            new CharacterMessage("ぼくも一緒に考えてるから、心配しないで！"),
            new CharacterMessage("頭を柔らかくしてみると見えてくるかも！"),
            new CharacterMessage("ちょっとヒントを試してみるのもアリかもね！"),
            new CharacterMessage("君が悩むなら、それは良い問題の証拠だよ！"),
            new CharacterMessage("答えにたどり着くまでの道も楽しもうよ！"),
            new CharacterMessage($"お互いのアイデアを組み合わせたら{Environment.NewLine}良い答えが出るかも！"),
            new CharacterMessage($"あ、もしかして！いや、違うかも…。{Environment.NewLine}君はどう思う？"),
            new CharacterMessage($"お互いの強みを出し合って解こう！{Environment.NewLine}ぼくも頑張る！"),
            new CharacterMessage($"失敗なんて気にしない！{Environment.NewLine}その先に正解があるよ！"),
            new CharacterMessage("結果よりも挑戦することが大事だよ！"),
            new CharacterMessage($"間違えた分だけ賢くなるって{Environment.NewLine}聞いたことあるよ！"),
            new CharacterMessage($"疑問を持つことが、{Environment.NewLine}すでに答えに近づいている証だよ。"),
            new CharacterMessage("もしかして、この問題、少しクセが強い？"),
            new CharacterMessage("難しいほど燃えるよね！"),
            new CharacterMessage("遊んでくれてありがとう！"),
        };
        private static List<CharacterMessage> FRemainingHintkunMessages = new List<CharacterMessage>(FAllHintkunMessages);
        private static CharacterMessage FCurrentHintkunMessage;
        private static Random FRandom = new Random();

        /// <summary>
        /// 最初のMessageをセットするためのコンストラクタ（GetCurrentHintkunMessage()の戻り値がnullになるのを防ぐ）
        /// </summary>
        static CharacterMessageManager() {
            SetInitialHintkunMessage();
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
        /// <returns>現在選択されている問題</returns>
        public static CharacterMessage GetCurrentHintkunMessage() {
            return FCurrentHintkunMessage;
        }
    }
}
