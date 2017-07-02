namespace Cookie.Protocol.Messages.Game.Context.Fight.Challenge
{
    [NetworkMessage(5614)]
    public class ChallengeTargetsListRequestMessage
    {
        [CustomVar]
        public ushort ChallengeId { get; set; }
    }
}