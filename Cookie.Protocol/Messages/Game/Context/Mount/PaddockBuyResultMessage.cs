using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(6516)]
    public class PaddockBuyResultMessage
    {
        public int PaddockId { get; set; }

        [RegularBool]
        public bool Bought { get; set; }

        [CustomVar]
        public long RealPrice { get; set; }
    }
}