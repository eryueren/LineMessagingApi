using Newtonsoft.Json;

namespace  LineMessaging.Core
{
    public class LineTextMessage : ILineMessage
    {
        [JsonProperty("type")]
        public MessageType Type => MessageType.Text;

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
