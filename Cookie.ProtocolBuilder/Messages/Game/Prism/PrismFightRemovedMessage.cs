namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(6453)]
    public class PrismFightRemovedMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }
    }
}