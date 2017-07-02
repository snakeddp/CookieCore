namespace Cookie.Protocol.Types.Game.Paddock
{
    [NetworkType(184)]
    public class MountInformationsForPaddock
    {
        [CustomVar]
        public ushort ModelId { get; set; }

        public string Name { get; set; }
        public string OwnerName { get; set; }
    }
}