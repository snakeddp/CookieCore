using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Data.Items
{
    [NetworkType(124)]
    public class ObjectItemMinimalInformation : Item
    {
        [CustomVar]
        public ushort ObjectGID { get; set; }
    }
}