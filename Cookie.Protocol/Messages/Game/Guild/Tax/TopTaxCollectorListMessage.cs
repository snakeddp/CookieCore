
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(6565)]
    public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage
    {
        [RegularBool]
        public bool IsDungeon { get; set; }
    }
}
