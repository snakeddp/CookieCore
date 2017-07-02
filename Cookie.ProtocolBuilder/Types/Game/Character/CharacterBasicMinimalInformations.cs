namespace Cookie.Protocol.Types.Game.Character
{
    [NetworkType(503)]
    public class CharacterBasicMinimalInformations : AbstractCharacterInformation
    {
        public string Name { get; set; }
    }
}