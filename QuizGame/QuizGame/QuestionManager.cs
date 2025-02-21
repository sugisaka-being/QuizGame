using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// 問題管理クラス
    /// </summary>
    internal static class QuestionManager {

        private static readonly List<Question> FAllQuestions = new List<Question>();
        private static List<Question> FRemainingQuestions = new List<Question>(FAllQuestions);
        private static Question FCurrentQuestion;
        private static Random FRandom = new Random();

        /// <summary>
        /// 最初の問題をセットするためのコンストラクタ（GetCurrentQuestion()の戻り値がnullになるのを防ぐ）
        /// </summary>
        static QuestionManager() {
            LoadQuestionsFromResource();
            SetRandomQuestion();
        }

        /// <summary>
        /// リソースファイルからクイズの問題情報を読み込み、問題文、解答、解説を抽出してリストに格納する
        /// </summary>
        private static void LoadQuestionsFromResource() {
            string wQuestionResourceName = "QuizGame.Resources.Questions.QuizQuestions.txt";
            Stream wQuestionsResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(wQuestionResourceName);
            if (wQuestionsResourceStream == null) {
                MessageBox.Show("指定されたリソースが見つかりませんでした：" + wQuestionResourceName);
                return;
            }

            using (var wQuestionsReader = new StreamReader(wQuestionsResourceStream)) {
                string[] wQuestionBlocks = wQuestionsReader.ReadToEnd().Split(new string[] { "----------" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var wQuestionBlock in wQuestionBlocks) {
                    var wQuestionDataLines = wQuestionBlock.Trim().Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                    string wQuestionText = ExtractSection(ref wQuestionDataLines);
                    string wAnswer = ExtractSection(ref wQuestionDataLines);
                    string wExplanation = ExtractSection(ref wQuestionDataLines);

                    FAllQuestions.Add(new Question(wQuestionText, wAnswer, wExplanation));
                }

                FRemainingQuestions = new List<Question>(FAllQuestions);
            }
        }

        /// <summary>
        /// リストの先頭から空白行をスキップし、空白でない行をセクションとして抽出する
        /// </summary>
        /// <param name="vQuestionDataLines">問題情報（問題文・解答・解説）を含む行のリスト</param>
        /// <returns>抽出されたセクション（問題文、解答、解説など）</returns>
        private static string ExtractSection(ref List<string> vQuestionDataLines) {
            SkipEmptyLines(ref vQuestionDataLines);

            var wQuestionSectionLines = vQuestionDataLines.TakeWhile(line => !string.IsNullOrWhiteSpace(line)).ToList();
            vQuestionDataLines.RemoveRange(0, wQuestionSectionLines.Count);

            return string.Join(Environment.NewLine, wQuestionSectionLines).Trim();
        }

        /// <summary>
        /// リストの最初にある空白行をすべて取り除く
        /// </summary>
        /// <param name="vQuestionDataLines">問題情報（問題文・解答・解説）を含む行のリスト</param>
        private static void SkipEmptyLines(ref List<string> vQuestionDataLines) {
            while (vQuestionDataLines.Count > 0 && string.IsNullOrWhiteSpace(vQuestionDataLines[0])) {
                vQuestionDataLines.RemoveAt(0);
            }
        }

        /// <summary>
        /// ランダムに問題を選択し、未出題リストから削除する（すべての問題が出題されると未出題リストはリセットされる）
        /// </summary>
        public static void SetRandomQuestion() {
            if (FRemainingQuestions.Count == 0) {
                FRemainingQuestions = new List<Question>(FAllQuestions);
            }
            int wQuestionIndex = FRandom.Next(FRemainingQuestions.Count);
            FCurrentQuestion = FRemainingQuestions[wQuestionIndex];
            FRemainingQuestions.RemoveAt(wQuestionIndex);
        }

        /// <summary>
        /// 現在の問題を取得する
        /// </summary>
        /// <returns>現在選択されている問題</returns>
        public static Question GetCurrentQuestion() {
            return FCurrentQuestion;
        }
    }
}
