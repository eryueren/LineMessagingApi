﻿using Newtonsoft.Json;

namespace  LineMessaging.Core
{
    public class LineMembers
    {
        [JsonProperty("memberIds")]
        public string[] MemberIds { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}
