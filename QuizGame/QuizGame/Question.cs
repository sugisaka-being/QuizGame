namespace QuizGame {
    /// <summary>
    /// クイズの問題
    /// </summary>
    internal class Question {
        /// <summary>
        /// 問題文
        /// </summary>
        public string QuestionText { get; }

        /// <summary>
        /// 解答
        /// </summary>
        public string Answer { get; }

        /// <summary>
        /// 解説
        /// </summary>
        public string Explanation { get; }

        /// <summary>
        /// クイズの問題クラスのコンストラクタ
        /// </summary>
        /// <param name="vQuestion">問題文</param>
        /// <param name="vAnswer">解答</param>
        /// <param name="vExplanation">解説</param>
        public Question(string vQuestion, string vAnswer, string vExplanation) {
            this.QuestionText = vQuestion;
            this.Answer = vAnswer;
            this.Explanation = vExplanation;
        }
    }
}
