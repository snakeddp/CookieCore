namespace Cookie.Protocol.Types.Game.Data.Items.Effects
{
    [NetworkType(76)]
    public class ObjectEffect
    {
        [CustomVar]
        public ushort ActionId { get; set; }
    }
}