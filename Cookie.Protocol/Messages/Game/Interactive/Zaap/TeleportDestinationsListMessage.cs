using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Interactive.Zaap
{
    [NetworkMessage(5960)]
    public class TeleportDestinationsListMessage
    {
        public sbyte TeleporterType { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] MapIds { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] SubAreaIds { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Costs { get; set; }

        [LengthType(typeof(short), true)]
        public sbyte[] DestTeleporterType { get; set; }
    }
}