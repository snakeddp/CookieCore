namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5634)]
    public class TaxCollectorErrorMessage
    {
        public byte Reason { get; set; }
    }
}