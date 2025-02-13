using System.Windows.Forms;

namespace QuizGame {
    /// <summary>
    /// フォーム管理クラス
    /// </summary>
    internal static class FormManager {
        private static Form FCurrentForm;

        /// <summary>
        /// 現在のフォームを閉じて、新しいフォームを表示する
        /// </summary>
        /// <param name="vNewForm">新しいフォーム</param>
        public static void ShowForm(Form vNewForm) {
            if (FCurrentForm == null) {
                FCurrentForm = vNewForm;
                vNewForm.Show();
                vNewForm.FormClosed += CheckAndExit;
                return;
            }
            vNewForm.Show();
            FCurrentForm.Close();
            FCurrentForm.Dispose();
            FCurrentForm = vNewForm;
            vNewForm.FormClosed += CheckAndExit;
        }

        /// <summary>
        /// フォームが閉じられた際に。アプリケーションを終了するか確認するメソッド
        /// </summary>
        /// <param name="sender">閉じられたフォーム</param>
        /// <param name="e">フォームのクローズイベント情報</param>
        private static void CheckAndExit(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms.Count == 1) {
                Application.Exit();
            }
        }
    }
}
