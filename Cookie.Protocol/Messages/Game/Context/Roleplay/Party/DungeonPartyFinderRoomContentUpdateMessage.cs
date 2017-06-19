
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay.Party;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6250)]
    public class DungeonPartyFinderRoomContentUpdateMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public long[] RemovedPlayersIds { get; set; }
    }
}
