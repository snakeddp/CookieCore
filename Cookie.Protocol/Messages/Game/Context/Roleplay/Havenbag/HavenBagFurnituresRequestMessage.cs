
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    [NetworkMessage(6637)]
    public class HavenBagFurnituresRequestMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] CellIds { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public int[] FunitureIds { get; set; }
        [LengthType(typeof(short), true)]
        public sbyte[] Orientations { get; set; }
    }
}
