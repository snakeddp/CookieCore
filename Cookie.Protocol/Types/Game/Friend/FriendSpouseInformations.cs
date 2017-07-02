using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Friend
{
    [NetworkType(77)]
    public class FriendSpouseInformations
    {
        public uint SpouseAccountId { get; set; }

        [CustomVar]
        public long SpouseId { get; set; }

        public string SpouseName { get; set; }
        public sbyte SpouseLevel { get; set; }
        public byte Breed { get; set; }
        public byte Sex { get; set; }
        public EntityLook SpouseEntityLook { get; set; }
        public GuildInformations GuildInfo { get; set; }
        public byte AlignmentSide { get; set; }
    }
}