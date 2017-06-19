
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5819)]
    public class ExchangeStartOkJobIndexMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] Jobs { get; set; }
    }
}
