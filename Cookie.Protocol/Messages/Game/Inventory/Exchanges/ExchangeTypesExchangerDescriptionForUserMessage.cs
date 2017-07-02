using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5765)]
    public class ExchangeTypesExchangerDescriptionForUserMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] TypeDescription { get; set; }
    }
}