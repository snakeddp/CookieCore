using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5953)]
    public class PaddockSellRequestMessage
    {
        [CustomVar]
        public long Price { get; set; }

        [RegularBool]
        public bool ForSale { get; set; }
    }
}