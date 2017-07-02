using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    [NetworkMessage(6630)]
    public class RoomAvailableUpdateMessage
    {
        public sbyte NbRoom { get; set; }
    }
}