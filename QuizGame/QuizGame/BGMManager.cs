using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace QuizGame {
    /// <summary>
    /// BGM管理クラス
    /// </summary>
    public static class BGMManager {
        private static WindowsMediaPlayer FBgmPlayer = new WindowsMediaPlayer();
        private static string FBGMTempFilePath;

        /// <summary>
        /// BGMを再生する
        /// </summary>
        /// <param name="vBGMFileName">BGMファイルの名前</param>
        public static void PlayBGM(string vBGMFileName) {
            try {
                string wResourceBGM = $"QuizGame.Resources.BGM.{vBGMFileName}";
                using (Stream wBGMStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(wResourceBGM)) {
                    if (wBGMStream == null) {
                        MessageBox.Show("BGMファイルが見つかりませんでした");
                        return;
                    }
                    FBGMTempFilePath = Path.Combine(Path.GetTempPath(), vBGMFileName);
                    using (var wFileStream = new FileStream(FBGMTempFilePath, FileMode.Create, FileAccess.Write)) {
                        wBGMStream.CopyTo(wFileStream);
                    }
                    FBgmPlayer.controls.stop();
                    FBgmPlayer.URL = FBGMTempFilePath;
                    FBgmPlayer.settings.setMode("loop", true);
                    FBgmPlayer.settings.volume = 30;
                    FBgmPlayer.controls.play();
                }
            } catch (Exception ex) {
                MessageBox.Show($"BGMの再生に失敗しました：{ex.Message}");
            }
        }

        /// <summary>
        /// BGMを停止する
        /// </summary>
        public static void StopBGM() {
            try {
                FBgmPlayer.controls.stop();
                if (File.Exists(FBGMTempFilePath)) {
                    File.Delete(FBGMTempFilePath);
                } else {
                    MessageBox.Show("BGMファイルが見つからなかったため削除できませんでした。");
                }
            } catch (Exception ex) {
                MessageBox.Show($"BGMの停止に失敗しました：{ex.Message}");
            }
        }
    }
}
