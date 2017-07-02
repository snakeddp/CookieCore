namespace Cookie.Protocol.Messages.Game.Script
{
    [NetworkMessage(6053)]
    public class CinematicMessage
    {
        [CustomVar]
        public ushort CinematicId { get; set; }
    }
}