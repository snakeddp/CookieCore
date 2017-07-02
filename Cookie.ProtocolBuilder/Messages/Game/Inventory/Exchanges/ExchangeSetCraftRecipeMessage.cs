namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6389)]
    public class ExchangeSetCraftRecipeMessage
    {
        [CustomVar]
        public ushort ObjectGID { get; set; }
    }
}