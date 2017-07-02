namespace Cookie.Protocol.Messages.Game.Pvp
{
    [NetworkMessage(6058)]
    public class AlignmentRankUpdateMessage
    {
        public sbyte AlignmentRank { get; set; }

        [RegularBool]
        public bool Verbose { get; set; }
    }
}