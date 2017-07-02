namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6269)]
    public class PartyPledgeLoyaltyRequestMessage : AbstractPartyMessage
    {
        [RegularBool]
        public bool Loyal { get; set; }
    }
}