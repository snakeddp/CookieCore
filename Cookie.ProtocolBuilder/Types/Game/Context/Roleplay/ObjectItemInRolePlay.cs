namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(198)]
    public class ObjectItemInRolePlay
    {
        [CustomVar]
        public ushort CellId { get; set; }

        [CustomVar]
        public ushort ObjectGID { get; set; }
    }
}