namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(156)]
    public class GameRolePlayNpcInformations : GameRolePlayActorInformations
    {
        [CustomVar]
        public ushort NpcId { get; set; }

        [RegularBool]
        public bool Sex { get; set; }

        [CustomVar]
        public ushort SpecialArtworkId { get; set; }
    }
}