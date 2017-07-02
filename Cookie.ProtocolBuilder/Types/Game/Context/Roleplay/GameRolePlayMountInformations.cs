namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(180)]
    public class GameRolePlayMountInformations : GameRolePlayNamedActorInformations
    {
        public string OwnerName { get; set; }
        public sbyte Level { get; set; }
    }
}