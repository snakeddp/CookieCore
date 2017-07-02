namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6423)]
    public class AllianceFactsErrorMessage
    {
        [CustomVar]
        public uint AllianceId { get; set; }
    }
}