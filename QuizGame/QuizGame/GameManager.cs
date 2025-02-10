using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame {
    /// <summary>
    /// クイズの問題数や得点を管理するクラス
    /// </summary>
    class GameManager {

        /// <summary>
        /// 現在の得点を取得する
        /// </summary>
        public static int Score { get; set; } = 0;

        /// <summary>
        /// 現在の問題数を取得する
        /// </summary>
        public static int CurrentQuestion { get; set; } = 1;

        /// <summary>
        /// 出題される最大問題数を設定
        /// </summary>
        public static int MaxQuestions => 5;

        /// <summary>
        /// 現在の得点を「○○点」の文字列形式で返すメソッド
        /// </summary>
        /// <returns></returns>
        public static string GetFormattedScore() {
            return $"{Score}点";
        }

        /// <summary>
        /// ゲームの状態をリセットするメソッド
        /// </summary>
        public static void ResetGame() {
            Score = 0;
            CurrentQuestion = 1;
        }
    }
}
