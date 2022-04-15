using Newtonsoft.Json;

namespace  LineMessaging.Core
{
    public class LineRichMenuResponse : LineRichMenu
    {
        [JsonProperty("richMenuId")]
        public string RichMenuId { get; set; }
    }
}
