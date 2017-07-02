using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Script
{
    [NetworkMessage(6266)]
    public class URLOpenMessage
    {
        public sbyte UrlId { get; set; }
    }
}