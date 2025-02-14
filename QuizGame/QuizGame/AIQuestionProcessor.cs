using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizGame {
    /// <summary>
    /// ヒント処理を行うクラス
    /// </summary>
    class AIQuestionProcessor {
        private readonly string FEndpoint = "https://aoai-ui-being-swc-prd-001.openai.azure.com/";
        private readonly string FApiKey = "b8dcde6dbd7341ae9697e66908d4bc86";
        private readonly string FDeploymentName = "gpt4-turbo-ui-001";
        private readonly string FApiUrl;

        /// <summary>
        /// ヒント処理を行うクラスのコンストラクタ
        /// </summary>
        public AIQuestionProcessor() {
            FApiUrl = FEndpoint + "openai/deployments/" + FDeploymentName + "/chat/completions?api-version=2024-02-01";
        }

        /// <summary>
        /// ユーザの入力に対して、AIからの応答を取得するメソッド
        /// </summary>
        /// <param name="vUserInputMessage">ユーザーからの入力メッセージ</param>
        /// <returns>AIによって生成されたメッセージ</returns>
        public string GetAIResponse(string vUserInputMessage) {
            var wRequestBody = new RequestBody {
                Messages = new Message[]
                {
                new Message { Role = "system", Content = "あなたはクイズゲームのアシスタントです。" },
                new Message { Role = "system", Content = "最大50文字以内で簡潔に回答してください" },
                new Message { Role = "system", Content = "敬語ではなく、フレンドリーな返答をしてください" },
                new Message { Role = "system", Content = "文章の語尾にはナルをつけてください" },
                new Message { Role = "user", Content = vUserInputMessage }
                },
                MaxTokens = 100
            };

            string wJsonRequestBody = SerializeToJson(wRequestBody);

            using (var wApiClient = new HttpClient()) {
                wApiClient.DefaultRequestHeaders.Add("api-key", FApiKey);
                var wRequestContent = new StringContent(wJsonRequestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage wApiResponse = wApiClient.PostAsync(FApiUrl, wRequestContent).Result;
                string wJsonResponse = wApiResponse.Content.ReadAsStringAsync().Result;
                return DeserializeFromJson(wJsonResponse);
            }
        }

        /// <summary>
        /// 指定されたRequestBodyオブジェクトをJSON形式の文字列にシリアライズするメソッド
        /// </summary>
        /// <param name="vRequestBody">シリアライズするRequestBodyオブジェクト</param>
        /// <returns>シリアライズされたJSON形式の文字列</returns>
        private string SerializeToJson(RequestBody vRequestBody) {
            using (var wStream = new MemoryStream()) {
                var wJsonSerializer = new DataContractJsonSerializer(typeof(RequestBody));
                wJsonSerializer.WriteObject(wStream, vRequestBody);
                return Encoding.UTF8.GetString(wStream.ToArray());
            }
        }

        /// <summary>
        /// 指定されたJSON形式のレスポンスをデシリアライズし、AIの応答メッセージを取得するメソッド
        /// </summary>
        /// <param name="vJsonResponse">シリアライズするJSON形式の文字列(AIからのレスポンス)</param>
        /// <returns>AIからの応答メッセージ(エラーが発生したらエラーメッセージ)</returns>
        private string DeserializeFromJson(string vJsonResponse) {
            using (var wStream = new MemoryStream(Encoding.UTF8.GetBytes(vJsonResponse))) {
                var wSerializer = new DataContractJsonSerializer(typeof(ResponseBody));
                var wDeserializedResponse = (ResponseBody)wSerializer.ReadObject(wStream);

                // AOAIのコンテンツフィルタリングに該当する質問だった場合
                if (wDeserializedResponse.Error != null && wDeserializedResponse.Error.Code == "content_filter") {
                    return "その質問は良くない質問なんじゃないかな。" + Environment.NewLine + "ボクには答えられないよ。" + Environment.NewLine + "違う質問をしてみて！";
                }

                if (wDeserializedResponse == null ||
                    wDeserializedResponse.Choices == null ||
                    wDeserializedResponse.Choices.Length == 0 ||
                    wDeserializedResponse.Choices[0].Message == null ||
                    string.IsNullOrEmpty(wDeserializedResponse.Choices[0].Message.Content)) {
                    return "ごめんね、うまく考えがまとまらなかったナル..." + Environment.NewLine + "他の質問をしてみて！";
                }
                return wDeserializedResponse.Choices[0].Message.Content;
            }
        }
    }
}

