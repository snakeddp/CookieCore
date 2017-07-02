using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6021)]
    public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage
    {
        [RegularBool]
        public bool Allow { get; set; }
    }
}