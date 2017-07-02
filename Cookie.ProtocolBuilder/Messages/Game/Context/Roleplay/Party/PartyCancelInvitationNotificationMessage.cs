namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6251)]
    public class PartyCancelInvitationNotificationMessage : AbstractPartyEventMessage
    {
        [CustomVar]
        public long CancelerId { get; set; }

        [CustomVar]
        public long GuestId { get; set; }
    }
}