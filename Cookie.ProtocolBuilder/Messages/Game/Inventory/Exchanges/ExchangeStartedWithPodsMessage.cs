namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6129)]
    public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
    {
        public double FirstCharacterId { get; set; }

        [CustomVar]
        public uint FirstCharacterCurrentWeight { get; set; }

        [CustomVar]
        public uint FirstCharacterMaxWeight { get; set; }

        public double SecondCharacterId { get; set; }

        [CustomVar]
        public uint SecondCharacterCurrentWeight { get; set; }

        [CustomVar]
        public uint SecondCharacterMaxWeight { get; set; }
    }
}