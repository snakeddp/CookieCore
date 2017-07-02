using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6249)]
    public class DungeonPartyFinderRegisterRequestMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] DungeonIds { get; set; }
    }
}