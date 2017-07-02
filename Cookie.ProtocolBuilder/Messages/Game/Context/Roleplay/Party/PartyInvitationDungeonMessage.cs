namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6244)]
    public class PartyInvitationDungeonMessage : PartyInvitationMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}