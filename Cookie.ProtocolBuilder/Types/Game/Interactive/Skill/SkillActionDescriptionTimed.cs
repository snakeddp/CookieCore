namespace Cookie.Protocol.Types.Game.Interactive.Skill
{
    [NetworkType(103)]
    public class SkillActionDescriptionTimed : SkillActionDescription
    {
        public sbyte Time { get; set; }
    }
}