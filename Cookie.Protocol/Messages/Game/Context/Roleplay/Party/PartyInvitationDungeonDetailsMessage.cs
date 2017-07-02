using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6262)]
    public class PartyInvitationDungeonDetailsMessage : PartyInvitationDetailsMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }

        [LengthType(typeof(short), true)]
        public bool[] PlayersDungeonReady { get; set; }
    }
}