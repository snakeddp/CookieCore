using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5720)]
    public class GuildFightPlayersHelpersJoinMessage
    {
        public uint FightId { get; set; }
        public CharacterMinimalPlusLookInformations PlayerInfo { get; set; }
    }
}