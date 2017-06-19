
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay.Party;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6247)]
    public class DungeonPartyFinderRoomContentMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}
