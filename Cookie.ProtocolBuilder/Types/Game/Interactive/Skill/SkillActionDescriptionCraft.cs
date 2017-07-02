namespace Cookie.Protocol.Types.Game.Interactive.Skill
{
    [NetworkType(100)]
    public class SkillActionDescriptionCraft : SkillActionDescription
    {
        public sbyte Probability { get; set; }
    }
}