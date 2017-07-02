namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(5937)]
    public class GameRolePlayPlayerFightFriendlyRequestedMessage
    {
        public uint FightId { get; set; }

        [CustomVar]
        public long SourceId { get; set; }

        [CustomVar]
        public long TargetId { get; set; }
    }
}