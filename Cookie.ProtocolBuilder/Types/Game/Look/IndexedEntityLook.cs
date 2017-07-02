namespace Cookie.Protocol.Types.Game.Look
{
    [NetworkType(405)]
    public class IndexedEntityLook
    {
        public EntityLook Look { get; set; }
        public sbyte Index { get; set; }
    }
}