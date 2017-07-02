namespace Cookie.Protocol.Types.Game.Character.Alignment
{
    [NetworkType(201)]
    public class ActorAlignmentInformations
    {
        public byte AlignmentSide { get; set; }
        public sbyte AlignmentValue { get; set; }
        public sbyte AlignmentGrade { get; set; }
        public double CharacterPower { get; set; }
    }
}