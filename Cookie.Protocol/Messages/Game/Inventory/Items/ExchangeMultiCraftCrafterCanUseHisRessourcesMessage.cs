
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6020)]
    public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage
    {
        [RegularBool]
        public bool Allowed { get; set; }
    }
}
