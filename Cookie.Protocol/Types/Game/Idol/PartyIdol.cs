using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Idol
{
    [NetworkType(490)]
    public class PartyIdol : Idol
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public long[] OwnersIds { get; set; }
    }
}