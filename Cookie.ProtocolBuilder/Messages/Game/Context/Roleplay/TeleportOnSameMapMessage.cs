namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(6048)]
    public class TeleportOnSameMapMessage
    {
        public double TargetId { get; set; }

        [CustomVar]
        public ushort CellId { get; set; }
    }
}