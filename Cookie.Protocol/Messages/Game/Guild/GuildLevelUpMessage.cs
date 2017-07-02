using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6062)]
    public class GuildLevelUpMessage
    {
        public sbyte NewLevel { get; set; }
    }
}