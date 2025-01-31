using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame {
    public partial class Rule : Form {
        public Rule() {
            InitializeComponent();
            label2.Text = "ようこそ、ときタクナルへ！このゲームでは、ヒント君と協力してクイズを解いていきます。\n\n" +
                "ゲームの流れ\n" +
                "　全5問のクイズに挑戦します！各問題ごとに、あなたの答えを入力してください。\n" +
                "　答えに迷ったときは、ヒント君に質問してみましょう！\n" +
                "　ヒント君が質問に答えて、クイズ攻略を手助けしてくれます。\n\n" +
                "得点について\n" +
                "　1問正解するごとに10点が加算されます。\n" +
                "　答えが合っているかどうかは、解説を読んであなた自身で判定してください。\n\n" +
                "すべての問題を正解し、ハイスコアを目指しましょう！\n";
        }
    }
}
