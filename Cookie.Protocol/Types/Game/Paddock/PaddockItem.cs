
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;
using Cookie.Protocol.Types.Game.Mount;

namespace Cookie.Protocol.Types.Game.Paddock
{
    [NetworkType(185)]
    public class PaddockItem : ObjectItemInRolePlay
    {
        public ItemDurability Durability { get; set; }
    }
}
