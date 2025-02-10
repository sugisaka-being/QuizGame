namespace QuizGame {
    /// <summary>
    /// キャラクターメッセージクラス
    /// </summary>
    internal class CharacterMessage {
        /// <summary>
        /// ヒント君メッセージ
        /// </summary>
        public string HintkunMessage { get; }

        /// <summary>
        /// キャラクターメッセージクラスのコンストラクタ
        /// </summary>
        /// <param name="vHintkunMessage">ヒント君メッセージ</param>
        public CharacterMessage(string vHintkunMessage) {
            this.HintkunMessage = vHintkunMessage;
        }
    }
}
