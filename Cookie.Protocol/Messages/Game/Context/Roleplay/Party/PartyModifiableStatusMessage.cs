using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6277)]
    public class PartyModifiableStatusMessage : AbstractPartyMessage
    {
        [RegularBool]
        public bool Enabled { get; set; }
    }
}