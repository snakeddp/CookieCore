using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(5677)]
    public class IgnoredDeleteResultMessage
    {
        public bool Success { get; set; }
        public string Name { get; set; }
        public bool Session { get; set; }
    }
}