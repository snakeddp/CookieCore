
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6284)]
    public class GameRolePlayArenaRegistrationStatusMessage
    {
        [RegularBool]
        public bool Registered { get; set; }
        public sbyte Step { get; set; }
        public uint BattleMode { get; set; }
    }
}
