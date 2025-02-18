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
        /// 正解時にスコア加算される点数
        /// </summary>
        public const int C_CorrectAnswerPoints = 10;

        /// <summary>
        /// 現在の得点
        /// </summary>
        public static int Score { get; private set; } = 0;

        /// <summary>
        /// 現在の問題番号
        /// </summary>
        public static int CurrentQuestion { get; private set; } = 1;


        /// <summary>
        /// 現在の得点を「○○点」の文字列形式で返すメソッド
        /// </summary>
        /// <returns></returns>
        public static string GetFormattedScore() {
            return $"{Score}点";
        }

        /// <summary>
        /// 指定した点数をスコアに加算するメソッド
        /// </summary>
        /// <param name="vScorePoints"></param>
        public static void AddScore(int vScorePoints) {
                Score += vScorePoints;
        }

        /// <summary>
        /// 現在が何問目かという問題番号を返す
        /// </summary>
        /// <returns>現在の問題番号</returns>
        public static int GetCurrentQuestionNumber() {
            return CurrentQuestion;
        }

        /// <summary>
        /// 問題番号を1増やす（次の問題に進む）
        /// </summary>
        public static void ProceedToNextQuestion() {
            if (CurrentQuestion < C_MaxQuestions) {
                CurrentQuestion++;
            }
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
