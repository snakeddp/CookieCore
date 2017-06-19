
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5557)]
    public class GuildInformationsGeneralMessage
    {
        [RegularBool]
        public bool AbandonnedPaddock { get; set; }
        public sbyte Level { get; set; }
        [CustomVar]
        public long ExpLevelFloor { get; set; }
        [CustomVar]
        public long Experience { get; set; }
        [CustomVar]
        public long ExpNextLevelFloor { get; set; }
        public uint CreationDate { get; set; }
        [CustomVar]
        public ushort NbTotalMembers { get; set; }
        [CustomVar]
        public ushort NbConnectedMembers { get; set; }
    }
}
