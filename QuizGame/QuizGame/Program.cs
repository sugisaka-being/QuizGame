using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame {
    class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            Task.Run(async () => await InitializeAsync()).GetAwaiter().GetResult();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new StartForm());
        }

        /// <summary>
        /// アプリケーションの初期化を非同期で行い、効果音をプリロードするメソッド
        /// </summary>
        /// <returns></returns>
        static async Task InitializeAsync() {
            await SoundManager.Instance.PreloadSoundsAsync();
        }
    }
}
