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
    class AIQuestionProcessor {
        private readonly string FEndpoint = "https://aoai-ui-being-swc-prd-001.openai.azure.com/";
        private readonly string FApiKey = "b8dcde6dbd7341ae9697e66908d4bc86";
        private readonly string FDeploymentName = "gpt4-turbo-ui-001";
        private readonly string FApiUrl;

        public AIQuestionProcessor() {
            FApiUrl = FEndpoint + "openai/deployments/" + FDeploymentName + "/chat/completions?api-version=2024-02-01";
        }


        public string GetAIResponse(string vUserInput) {
            var wRequestBody = new RequestBody {
                Messages = new Message[]
                {
                new Message { Role = "system", Content = "あなたはクイズゲームのアシスタントです。" },
                new Message { Role = "system", Content = "最大50文字以内で簡潔に回答してください" },
                new Message { Role = "system", Content = "敬語ではなく、フレンドリーな返答をしてください" },
                new Message { Role = "system", Content = "文章の語尾にはナルをつけてください" },
                new Message { Role = "user", Content = vUserInput }
                },
                MaxTokens = 100
            };

            string wJsonRequest = SerializeToJson(wRequestBody);

            using (var wClient = new HttpClient()) {
                wClient.DefaultRequestHeaders.Add("api-key", FApiKey);
                var wContent = new StringContent(wJsonRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage wResponse = wClient.PostAsync(FApiUrl, wContent).Result;
                string wJsonResponse = wResponse.Content.ReadAsStringAsync().Result;


                // APIのレスポンスを出力して確認するコード
                
                Clipboard.SetText(wJsonResponse);
                MessageBox.Show("API Response: " + wJsonResponse, "API デバッグ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return DeserializeFromJson(wJsonResponse);
            }
        }



        private string SerializeToJson(RequestBody vRequestBody) {
            using (var wStream = new MemoryStream()) {
                var wSerializer = new DataContractJsonSerializer(typeof(RequestBody));
                wSerializer.WriteObject(wStream, vRequestBody);
                return Encoding.UTF8.GetString(wStream.ToArray());
            }
        }



        private string DeserializeFromJson(string vJsonResponse) {
            using (var wStream = new MemoryStream(Encoding.UTF8.GetBytes(vJsonResponse))) {
                var wSerializer = new DataContractJsonSerializer(typeof(ResponseBody));
                var wResponse = (ResponseBody)wSerializer.ReadObject(wStream);


                // nullチェックを追加
                if (wResponse == null) {
                    return "エラー: APIレスポンスがnullです。";
                }
                if (wResponse.Choices == null || wResponse.Choices.Length == 0) {
                    return "エラー: AIの応答が無効です。（Choicesが空またはnull）";
                }
                if (wResponse.Choices[0].Message == null || string.IsNullOrEmpty(wResponse.Choices[0].Message.Content)) {
                    return "エラー: AIからの回答が取得できませんでした。";
                }


                return wResponse.Choices[0].Message.Content;
            }
        }



    }
}

