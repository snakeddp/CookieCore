using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Paddock
{
    [NetworkType(222)]
    public class PaddockInformationsForSell
    {
        public string GuildOwner { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        public byte NbMount { get; set; }
        public byte NbObject { get; set; }

        [CustomVar]
        public long Price { get; set; }
    }
}