
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(6525)]
    public class CurrentServerStatusUpdateMessage
    {
        public sbyte Status { get; set; }
    }
}
