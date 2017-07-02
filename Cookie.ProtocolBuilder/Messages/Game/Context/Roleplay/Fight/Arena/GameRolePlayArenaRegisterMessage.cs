namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6280)]
    public class GameRolePlayArenaRegisterMessage
    {
        public uint BattleMode { get; set; }
    }
}