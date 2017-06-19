
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5818)]
    public class ExchangeStartOkMulticraftCrafterMessage
    {
        [CustomVar]
        public uint SkillId { get; set; }
    }
}
