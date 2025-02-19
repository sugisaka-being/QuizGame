using System;
using System.IO;
using System.Media;
using System.Reflection;
using System.Threading.Tasks;

namespace QuizGame {
    /// <summary>
    /// ゲーム内で使用する効果音を管理するクラス
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

        /// <summary>
        ///  SoundManager クラスのインスタンスを初期化し、ゲームで使用する音を埋め込みリソースから読み込むコンストラクタ
        /// </summary>
        public SoundManager() {
            FClickSound = CreateSoundPlayer("QuizGame.Resources.Sounds.クリック音.wav");
            FGameStartSound = CreateSoundPlayer("QuizGame.Resources.Sounds.ゲームスタート.wav");
            FResultSound = CreateSoundPlayer("QuizGame.Resources.Sounds.シンプル結果発表.wav");
            FGoHintSound = CreateSoundPlayer("QuizGame.Resources.Sounds.ヒント君遷移時.wav");
            FAnswerSound = CreateSoundPlayer("QuizGame.Resources.Sounds.解答.wav");
            FCorrectSound = CreateSoundPlayer("QuizGame.Resources.Sounds.正解.wav");
            FIncorrectSound = CreateSoundPlayer("QuizGame.Resources.Sounds.不正解.wav");
            FReturnSound = CreateSoundPlayer("QuizGame.Resources.Sounds.戻る.wav");
        }

        // SoundManager のシングルトンインスタンスを保持する静的フィールド
        private static SoundManager FInstance;

        /// <summary>
        ///  シングルトンインスタンスを返すプロパティ
        /// </summary>
        public static SoundManager Instance {
            get {
                if (FInstance == null) {
                    FInstance = new SoundManager();
                }
                return FInstance;
            }
        }

        /// <summary>
        /// 埋め込みリソースからSoundPlayerインスタンスを作成するメソッド
        /// </summary>
        private SoundPlayer CreateSoundPlayer(string vResourceName) {
            Stream wSoundStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(vResourceName);
            if (wSoundStream == null) {
                throw new InvalidOperationException($"リソース '{vResourceName}' が見つかりません。");
            }
            return new SoundPlayer(wSoundStream);
        }

        /// <summary>
        ///ゲームで使用するすべての音をロードするメソッド
        /// </summary>
        public void PreloadSounds() {
            PreloadSound("QuizGame.Resources.Sounds.クリック音.wav");
            PreloadSound("QuizGame.Resources.Sounds.ゲームスタート.wav");
            PreloadSound("QuizGame.Resources.Sounds.シンプル結果発表.wav");
            PreloadSound("QuizGame.Resources.Sounds.ヒント君遷移時.wav");
            PreloadSound("QuizGame.Resources.Sounds.解答.wav");
            PreloadSound("QuizGame.Resources.Sounds.正解.wav");
            PreloadSound("QuizGame.Resources.Sounds.不正解.wav");
            PreloadSound("QuizGame.Resources.Sounds.戻る.wav");
        }

        /// <summary>
        /// 指定されたリソース名の音をロードするメソッド
        /// </summary>
        /// <param name="vResourceName">ロードする効果音のリソース名</param>
        private void PreloadSound(string vResourceName) {
            CreateSoundPlayer(vResourceName);
        }

        /// <summary>
        /// 効果音を再生するメソッド
        /// </summary>
        public void PlayClickSound() => FClickSound.Play();
        public void PlayGameStartSound() => FGameStartSound.Play();
        public void PlayResultSound() => FResultSound.Play();
        public void PlayGoHintSound() => FGoHintSound.Play();
        public void PlayAnswerSound() => FAnswerSound.Play();
        public void PlayCorrectSound() => FCorrectSound.Play();
        public void PlayIncorrectSound() => FIncorrectSound.Play();
        public void PlayReturnSound() => FReturnSound.Play();

        // 結果発表音の再生終了を通知するイベント
        public event EventHandler ResultSoundPlaybackCompleted;

        /// <summary>
        /// 効果音を非同期で再生し、再生終了後にイベントを発生させるメソッド
        /// </summary>
        public async Task PlayResultSoundWithEvent() {
            await Task.Run(() => FResultSound.PlaySync());

            // 再生が終了したことを通知
            ResultSoundPlaybackCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}

