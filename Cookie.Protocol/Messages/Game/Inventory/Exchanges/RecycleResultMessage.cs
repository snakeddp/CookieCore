using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6601)]
    public class RecycleResultMessage
    {
        [CustomVar]
        public uint NuggetsForPrism { get; set; }

        [CustomVar]
        public uint NuggetsForPlayer { get; set; }
    }
}