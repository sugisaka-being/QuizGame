using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace QuizGame {
    /// <summary>
    /// BGM管理クラス
    /// </summary>
    public static class BGMManager {
        private static WindowsMediaPlayer FBGMPlayer = new WindowsMediaPlayer();

        /// <summary>
        /// 現在のBGMを停止し、指定した新しいBGMを再生する
        /// </summary>
        /// <param name="vBGMFileName">BGMファイルの名前</param>
        public static void PlayBGM(string vBGMFileName) {
            try {
                string wResourceBGM = $"QuizGame.Resources.BGM.{vBGMFileName}";
                string wTempFilePath = Path.Combine(Path.GetTempPath(), vBGMFileName);

                if (FBGMPlayer.URL == wTempFilePath) {
                    FBGMPlayer.controls.stop();
                    FBGMPlayer.URL = "";
                }
                if (File.Exists(wTempFilePath)) {
                    File.Delete(wTempFilePath);
                }

                using (Stream wBGMStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(wResourceBGM)) {
                    if (wBGMStream == null) {
                        MessageBox.Show("BGMファイルが見つかりませんでした");
                        return;
                    }
                    using (var wFileStream = new FileStream(wTempFilePath, FileMode.Create, FileAccess.Write)) {
                        wBGMStream.CopyTo(wFileStream);
                    }
                }
                FBGMPlayer.URL = wTempFilePath;
                FBGMPlayer.settings.setMode("loop", true);
                FBGMPlayer.settings.volume = 30;
                FBGMPlayer.controls.play();
            } catch (Exception ex) {
                MessageBox.Show($"BGMの再生に失敗しました：{ex.Message}");
            }
        }

        /// <summary>
        /// BGMを停止する
        /// </summary>
        public static void StopBGM() {
            try {
                FBGMPlayer.controls.stop();
                FBGMPlayer.URL = "";
            } catch (Exception ex) {
                MessageBox.Show($"BGMの停止に失敗しました：{ex.Message}");
            }
        }
    }
}
