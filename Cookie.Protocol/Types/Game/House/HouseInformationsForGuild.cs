using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.House
{
    [NetworkType(170)]
    public class HouseInformationsForGuild : HouseInformations
    {
        public uint InstanceId { get; set; }

        [RegularBool]
        public bool SecondHand { get; set; }

        public string OwnerName { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public int[] SkillListIds { get; set; }

        [CustomVar]
        public uint GuildshareParams { get; set; }
    }
}