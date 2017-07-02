namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6392)]
    public class AllianceInvitationStateRecrutedMessage
    {
        public sbyte InvitationState { get; set; }
    }
}