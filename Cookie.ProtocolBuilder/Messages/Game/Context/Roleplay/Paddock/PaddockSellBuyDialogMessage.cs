namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    [NetworkMessage(6018)]
    public class PaddockSellBuyDialogMessage
    {
        [RegularBool]
        public bool Bsell { get; set; }

        [CustomVar]
        public uint OwnerId { get; set; }

        [CustomVar]
        public long Price { get; set; }
    }
}