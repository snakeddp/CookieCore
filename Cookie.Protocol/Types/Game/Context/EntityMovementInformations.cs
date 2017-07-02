using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context
{
    [NetworkType(63)]
    public class EntityMovementInformations
    {
        public int Id { get; set; }

        [LengthType(typeof(short), true)]
        public byte[] Steps { get; set; }
    }
}