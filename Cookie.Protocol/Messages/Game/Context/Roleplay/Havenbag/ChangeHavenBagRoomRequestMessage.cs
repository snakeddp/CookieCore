
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    [NetworkMessage(6638)]
    public class ChangeHavenBagRoomRequestMessage
    {
        public sbyte RoomId { get; set; }
    }
}
