namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(159)]
    public class GameRolePlayHumanoidInformations : GameRolePlayNamedActorInformations
    {
        public HumanInformations HumanoidInfo { get; set; }
        public uint AccountId { get; set; }
    }
}