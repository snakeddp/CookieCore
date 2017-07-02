namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5581)]
    public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
    {
        public bool Success { get; set; }
        public bool IsFollowed { get; set; }

        [CustomVar]
        public long FollowedId { get; set; }
    }
}