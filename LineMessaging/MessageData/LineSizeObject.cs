using Newtonsoft.Json;

namespace  LineMessaging.Core
{
    public class LineSizeObject
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
