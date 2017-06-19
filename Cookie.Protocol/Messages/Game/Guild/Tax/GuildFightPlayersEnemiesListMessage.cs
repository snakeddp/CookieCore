
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5928)]
    public class GuildFightPlayersEnemiesListMessage
    {
        public uint FightId { get; set; }
    }
}
