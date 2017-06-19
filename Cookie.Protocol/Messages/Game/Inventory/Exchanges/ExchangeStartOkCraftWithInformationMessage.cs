
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5941)]
    public class ExchangeStartOkCraftWithInformationMessage : ExchangeStartOkCraftMessage
    {
        [CustomVar]
        public uint SkillId { get; set; }
    }
}
