namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5977)]
    public class MountSterilizedMessage
    {
        [CustomVar]
        public int MountId { get; set; }
    }
}