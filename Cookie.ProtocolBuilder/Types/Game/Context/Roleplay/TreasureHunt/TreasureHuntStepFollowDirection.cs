namespace Cookie.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    [NetworkType(468)]
    public class TreasureHuntStepFollowDirection : TreasureHuntStep
    {
        public sbyte Direction { get; set; }

        [CustomVar]
        public ushort MapCount { get; set; }
    }
}