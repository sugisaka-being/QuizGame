using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FCurrentForm.Hide();
            vNewForm.Show();
            FCurrentForm.Close();
            FCurrentForm = vNewForm;
            vNewForm.FormClosed += CheckAndExit;
        }

        private static void CheckAndExit(object sender, FormClosedEventArgs e) {
            if (Application.OpenForms.Count == 1) {
                Application.Exit();
            }
        }
    }
}
