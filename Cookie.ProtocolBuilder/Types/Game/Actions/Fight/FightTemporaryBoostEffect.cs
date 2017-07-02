namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(209)]
    public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
    {
        public short Delta { get; set; }
    }
}