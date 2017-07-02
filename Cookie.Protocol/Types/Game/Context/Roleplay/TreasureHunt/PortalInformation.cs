using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    [NetworkType(466)]
    public class PortalInformation
    {
        public int PortalId { get; set; }
        public short AreaId { get; set; }
    }
}