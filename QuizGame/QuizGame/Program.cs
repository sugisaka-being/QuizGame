using System;
using System.Windows.Forms;

namespace QuizGame {
    class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main() {
            PreloadStartupSounds();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BGMManager.PlayBGM("GameStartBGM.mp3");
            Application.Run(new StartForm());
            BGMManager.StopBGM();
        }

        /// <summary>
        /// 起動時に効果音のロードを行うメソッド
        /// </summary>
        static void PreloadStartupSounds() {
            SoundManager.Instance.PreloadSounds();
        }
    }
}
