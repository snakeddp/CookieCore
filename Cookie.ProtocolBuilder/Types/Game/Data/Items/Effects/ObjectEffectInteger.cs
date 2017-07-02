namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(70)]
    public class ObjectEffectInteger : ObjectEffect
    {
        [CustomVar]
        public uint Value { get; set; }
    }
}