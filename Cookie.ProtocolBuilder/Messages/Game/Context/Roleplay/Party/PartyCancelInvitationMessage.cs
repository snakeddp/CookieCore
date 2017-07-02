namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6254)]
    public class PartyCancelInvitationMessage : AbstractPartyMessage
    {
        [CustomVar]
        public long GuestId { get; set; }
    }
}