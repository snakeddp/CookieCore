namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6020)]
    public class ExchangeMultiCraftCrafterCanUseHisRessourcesMessage
    {
        [RegularBool]
        public bool Allowed { get; set; }
    }
}