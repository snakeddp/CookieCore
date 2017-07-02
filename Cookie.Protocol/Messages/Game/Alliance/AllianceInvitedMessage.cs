using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6397)]
    public class AllianceInvitedMessage
    {
        [CustomVar]
        public long RecruterId { get; set; }

        public string RecruterName { get; set; }
        public BasicNamedAllianceInformations AllianceInfo { get; set; }
    }
}