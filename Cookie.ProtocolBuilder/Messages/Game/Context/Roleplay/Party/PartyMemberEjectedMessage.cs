namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6252)]
    public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
    {
        [CustomVar]
        public long KickerId { get; set; }
    }
}