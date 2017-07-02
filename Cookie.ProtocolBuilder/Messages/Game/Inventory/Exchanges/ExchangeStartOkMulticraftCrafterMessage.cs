namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5818)]
    public class ExchangeStartOkMulticraftCrafterMessage
    {
        [CustomVar]
        public uint SkillId { get; set; }
    }
}