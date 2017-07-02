using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(179)]
    public class BasicWhoIsNoMatchMessage
    {
        public string Search { get; set; }
    }
}