namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6501)]
    public class PartyNameSetErrorMessage : AbstractPartyMessage
    {
        public sbyte Result { get; set; }
    }
}