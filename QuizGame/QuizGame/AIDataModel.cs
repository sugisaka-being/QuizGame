using System.Runtime.Serialization;

namespace QuizGame {

    /// <summary>
    /// OpenAI API へのリクエストボディを表すクラス
    /// </summary>
    [DataContract]
    public class RequestBody {

        /// <summary>
        /// API に送信するメッセージのリスト（システム・ユーザーなど）
        /// </summary>
        [DataMember(Name = "messages")]
        public Message[] Messages { get; set; }

        /// <summary>
        /// AI が生成する最大トークン数（回答の長さを制限）
        /// </summary>
        [DataMember(Name = "max_tokens")]
        public int MaxTokens { get; set; }
    }

    /// <summary>
    /// 会話のメッセージを表すクラス
    /// </summary>
    [DataContract]
    public class Message {

        /// <summary>
        /// メッセージの送信者（"system", "user", ）
        /// </summary>
        [DataMember(Name = "role")]
        public string Role { get; set; }

        /// <summary>
        /// メッセージの内容
        /// </summary>
        [DataMember(Name = "content")]
        public string Content { get; set; }
    }

    /// <summary>
    /// OpenAI API のレスポンスボディを表すクラス
    /// 返される選択肢は1つだけですが、APIの仕様として複数の選択肢を格納する配列形式になっている
    /// </summary>
    [DataContract]
    public class ResponseBody {

        /// <summary>
        /// AI の応答の配列（中身は1個)
        /// </summary>
        [DataMember(Name = "choices")]
        public Choice[] Choices { get; set; }
    }

    /// <summary>
    /// AI の応答の配列の要素
    /// </summary>
    [DataContract]
    public class Choice {

        /// <summary>
        /// AI の生成したメッセージ
        /// </summary>
        [DataMember(Name = "message")]
        public Message Message { get; set; }
    }
}