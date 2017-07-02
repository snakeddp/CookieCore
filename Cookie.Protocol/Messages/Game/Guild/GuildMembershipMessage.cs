using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5835)]
    public class GuildMembershipMessage : GuildJoinedMessage
    {
    }
}