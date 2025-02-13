namespace QuizGame {
    /// <summary>
    /// クイズの問題数や得点を管理するクラス
    /// </summary>
    static class GameManager {

        /// <summary>
        /// 出題される最大問題数
        /// </summary>
        public const int C_MaxQuestions = 5;

        /// <summary>
        /// 現在の得点
        /// </summary>
        public static int Score { get; set; } = 0;

        /// <summary>
        /// 現在の問題番号
        /// </summary>
        public static int CurrentQuestion { get; set; } = 1;


        /// <summary>
        /// 現在の得点を「○○点」の文字列形式で返すメソッド
        /// </summary>
        /// <returns></returns>
        public static string GetFormattedScore() {
            return $"{Score}点";
        }

        /// <summary>
        /// ゲームの状態をリセットするメソッド（スコアを0、問題番号を1問目に）
        /// </summary>
        public static void ResetGame() {
            Score = 0;
            CurrentQuestion = 1;
        }
    }
}
