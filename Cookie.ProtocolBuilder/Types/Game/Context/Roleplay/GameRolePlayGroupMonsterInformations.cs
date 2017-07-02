namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(160)]
    public class GameRolePlayGroupMonsterInformations : GameRolePlayActorInformations
    {
        public GroupMonsterStaticInformations StaticInfos { get; set; }
        public double CreationTime { get; set; }
        public uint AgeBonusRate { get; set; }
        public byte LootShare { get; set; }
        public byte AlignmentSide { get; set; }
        public bool KeyRingBonus { get; set; }
        public bool HasHardcoreDrop { get; set; }
        public bool HasAVARewardToken { get; set; }
    }
}