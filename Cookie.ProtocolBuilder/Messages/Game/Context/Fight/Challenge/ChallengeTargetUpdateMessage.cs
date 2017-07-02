namespace Cookie.Protocol.Messages.Game.Context.Fight.Challenge
{
    [NetworkMessage(6123)]
    public class ChallengeTargetUpdateMessage
    {
        [CustomVar]
        public ushort ChallengeId { get; set; }

        public double TargetId { get; set; }
    }
}