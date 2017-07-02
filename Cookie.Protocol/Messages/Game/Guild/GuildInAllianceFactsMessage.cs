using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6422)]
    public class GuildInAllianceFactsMessage : GuildFactsMessage
    {
        public BasicNamedAllianceInformations AllianceInfos { get; set; }
    }
}