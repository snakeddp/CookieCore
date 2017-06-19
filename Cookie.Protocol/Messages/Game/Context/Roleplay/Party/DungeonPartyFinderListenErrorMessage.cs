
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6248)]
    public class DungeonPartyFinderListenErrorMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}
