
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5951)]
    public class PaddockBuyRequestMessage
    {
        [CustomVar]
        public long ProposedPrice { get; set; }
    }
}
