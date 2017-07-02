using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(449)]
    public class HumanOptionObjectUse : HumanOption
    {
        public sbyte DelayTypeId { get; set; }
        public double DelayEndTime { get; set; }

        [CustomVar]
        public ushort ObjectGID { get; set; }
    }
}