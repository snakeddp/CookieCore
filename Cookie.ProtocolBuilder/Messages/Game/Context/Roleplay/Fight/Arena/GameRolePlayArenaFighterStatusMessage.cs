namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6281)]
    public class GameRolePlayArenaFighterStatusMessage
    {
        public int FightId { get; set; }
        public int PlayerId { get; set; }

        [RegularBool]
        public bool Accepted { get; set; }
    }
}