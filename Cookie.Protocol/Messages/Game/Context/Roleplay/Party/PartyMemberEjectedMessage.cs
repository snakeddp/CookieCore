
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6252)]
    public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
    {
        [CustomVar]
        public long KickerId { get; set; }
    }
}
