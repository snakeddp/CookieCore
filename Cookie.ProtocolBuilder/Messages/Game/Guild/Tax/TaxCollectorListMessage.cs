namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5930)]
    public class TaxCollectorListMessage : AbstractTaxCollectorListMessage
    {
        public sbyte NbcollectorMax { get; set; }
    }
}