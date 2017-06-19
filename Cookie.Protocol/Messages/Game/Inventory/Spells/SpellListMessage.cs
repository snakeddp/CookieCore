
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Spells
{
    [NetworkMessage(1200)]
    public class SpellListMessage
    {
        [RegularBool]
        public bool SpellPrevisualization { get; set; }
    }
}
