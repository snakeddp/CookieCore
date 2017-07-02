using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6247)]
    public class DungeonPartyFinderRoomContentMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}