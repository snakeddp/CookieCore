namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6276)]
    public class GameRolePlayArenaFightPropositionMessage
    {
        public uint FightId { get; set; }

        [LengthType(typeof(short), true)]
        public double[] AlliesId { get; set; }

        [CustomVar]
        public ushort Duration { get; set; }
    }
}