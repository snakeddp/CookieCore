namespace Cookie.Protocol.Types.Game.Character
{
    [NetworkType(193)]
    public class CharacterMinimalPlusLookAndGradeInformations : CharacterMinimalPlusLookInformations
    {
        [CustomVar]
        public uint Grade { get; set; }
    }
}