using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6242)]
    public class DungeonPartyFinderAvailableDungeonsMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] DungeonIds { get; set; }
    }
}