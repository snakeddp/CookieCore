using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6503)]
    public class PartyNameSetRequestMessage : AbstractPartyMessage
    {
        public string PartyName { get; set; }
    }
}