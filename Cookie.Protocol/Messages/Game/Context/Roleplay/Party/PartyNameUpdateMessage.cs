using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6502)]
    public class PartyNameUpdateMessage : AbstractPartyMessage
    {
        public string PartyName { get; set; }
    }
}