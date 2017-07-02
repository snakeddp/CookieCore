namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(6308)]
    public class MountReleasedMessage
    {
        [CustomVar]
        public int MountId { get; set; }
    }
}