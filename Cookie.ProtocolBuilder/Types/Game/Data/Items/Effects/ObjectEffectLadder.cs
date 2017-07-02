namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(81)]
    public class ObjectEffectLadder : ObjectEffectCreature
    {
        [CustomVar]
        public uint MonsterCount { get; set; }
    }
}