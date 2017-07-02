namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(5901)]
    public class PrismFightSwapRequestMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }

        [CustomVar]
        public long TargetId { get; set; }
    }
}