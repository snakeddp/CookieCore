
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6244)]
    public class PartyInvitationDungeonMessage : PartyInvitationMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }
    }
}
