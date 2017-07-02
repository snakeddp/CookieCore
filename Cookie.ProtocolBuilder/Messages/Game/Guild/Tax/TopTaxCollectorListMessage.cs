namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(6565)]
    public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
    {
        [RegularBool]
        public bool IsDungeon { get; set; }
    }
}