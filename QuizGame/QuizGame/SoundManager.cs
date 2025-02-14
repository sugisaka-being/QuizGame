using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame {
    /// <summary>
    /// 
    /// </summary>
    class SoundManager {
        private readonly SoundPlayer FClickSound;
        private readonly SoundPlayer FGameStartSound;
        private readonly SoundPlayer FResultSound;
        private readonly SoundPlayer FGoHintSound;
        private readonly SoundPlayer FAnswerSound;
        private readonly SoundPlayer FCorrectSound;
        private readonly SoundPlayer FIncorrectSound;
        private readonly SoundPlayer FReturnSound;

        public SoundManager() {

            string wBasePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Resources\Sounds");

            FClickSound = new SoundPlayer(Path.Combine(wBasePath, "クリック音.wav"));
            FGameStartSound = new SoundPlayer(Path.Combine(wBasePath, "ゲームスタート.wav"));
            FResultSound = new SoundPlayer(Path.Combine(wBasePath, "シンプル結果発表.wav"));
            FGoHintSound = new SoundPlayer(Path.Combine(wBasePath, "ヒント君遷移時.wav"));
            FAnswerSound = new SoundPlayer(Path.Combine(wBasePath, "解答.wav"));
            FCorrectSound = new SoundPlayer(Path.Combine(wBasePath, "正解.wav"));
            FIncorrectSound = new SoundPlayer(Path.Combine(wBasePath, "不正解.wav"));
            FReturnSound = new SoundPlayer(Path.Combine(wBasePath, "戻る.wav"));
        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadSounds() {
            try {
                FClickSound.Load();
                FGameStartSound.Load();
                FResultSound.Load();
                FGoHintSound.Load();
                FAnswerSound.Load();
                FCorrectSound.Load();
                FIncorrectSound.Load();
                FReturnSound.Load();
            } catch (Exception ex) {
                Console.WriteLine("効果音のロードに失敗しました: " + ex.Message);
            }
        }

        public void PlayClickSound() => FClickSound.Play();
        public void PlayGameStartSound() => FGameStartSound.Play();
        public void PlayResultSound() => FResultSound.Play();
        public void PlayGoHintSound() => FGoHintSound.Play();
        public void PlayAnswerSound() => FAnswerSound.Play();
        public void PlayCorrectSound() => FCorrectSound.Play();
        public void PlayIncorrectSound() => FIncorrectSound.Play();
        public void PlayReturnSound() => FReturnSound.Play();
    }
}

