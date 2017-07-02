namespace Cookie.Protocol.Messages.Game.Context.Fight.Challenge
{
    [NetworkMessage(5613)]
    public class ChallengeTargetsListMessage
    {
        [LengthType(typeof(short), true)]
        public double[] TargetIds { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public short[] TargetCells { get; set; }
    }
}