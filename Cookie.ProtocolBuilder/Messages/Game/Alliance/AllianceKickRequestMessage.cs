namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6400)]
    public class AllianceKickRequestMessage
    {
        [CustomVar]
        public uint KickedId { get; set; }
    }
}