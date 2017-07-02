namespace Cookie.Protocol.Types.Game.Interactive.Skill
{
    [NetworkType(102)]
    public class SkillActionDescription
    {
        [CustomVar]
        public ushort SkillId { get; set; }
    }
}