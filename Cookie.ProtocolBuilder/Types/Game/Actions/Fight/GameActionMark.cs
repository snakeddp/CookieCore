namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(351)]
    public class GameActionMark
    {
        public double MarkAuthorId { get; set; }
        public sbyte MarkTeamId { get; set; }
        public uint MarkSpellId { get; set; }
        public short MarkSpellLevel { get; set; }
        public short MarkId { get; set; }
        public byte MarkType { get; set; }
        public short MarkimpactCell { get; set; }

        [RegularBool]
        public bool Active { get; set; }
    }
}