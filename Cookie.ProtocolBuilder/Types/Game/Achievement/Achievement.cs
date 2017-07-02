namespace Cookie.Protocol.Types.Game.Achievement
{
    [NetworkType(363)]
    public class Achievement
    {
        [CustomVar]
        public ushort Id { get; set; }
    }
}