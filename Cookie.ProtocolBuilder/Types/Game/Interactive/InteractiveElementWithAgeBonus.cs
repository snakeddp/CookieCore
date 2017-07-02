namespace Cookie.Protocol.Types.Game.Interactive
{
    [NetworkType(398)]
    public class InteractiveElementWithAgeBonus : InteractiveElement
    {
        public short AgeBonus { get; set; }
    }
}