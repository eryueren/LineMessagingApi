using Newtonsoft.Json;

namespace  LineMessaging.Core
{
    public interface ILineMessage
    {
        MessageType Type { get; }
    }
}
