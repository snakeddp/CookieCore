using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Messages.Game.Context.Fight.Arena
{
    [NetworkMessage(6700)]
    public class ArenaFighterLeaveMessage
    {
        public CharacterBasicMinimalInformations Leaver { get; set; }
    }
}