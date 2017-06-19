
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6402)]
    public class AllianceJoinedMessage
    {
        public AllianceInformations AllianceInfo { get; set; }
        [RegularBool]
        public bool Enabled { get; set; }
        [CustomVar]
        public uint LeadingGuildId { get; set; }
    }
}
