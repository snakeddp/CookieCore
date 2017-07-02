namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(702)]
    public class GameFightJoinMessage
    {
        public bool IsTeamPhase { get; set; }
        public bool CanBeCancelled { get; set; }
        public bool CanSayReady { get; set; }
        public bool IsFightStarted { get; set; }
        public ushort TimeMaxBeforeFightStart { get; set; }
        public sbyte FightType { get; set; }
    }
}