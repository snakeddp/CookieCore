using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5784)]
    public class ExchangePlayerMultiCraftRequestMessage : ExchangeRequestMessage
    {
        [CustomVar]
        public long Target { get; set; }

        [CustomVar]
        public uint SkillId { get; set; }
    }
}