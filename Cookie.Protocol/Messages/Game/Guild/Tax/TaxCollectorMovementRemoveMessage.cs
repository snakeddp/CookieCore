using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5915)]
    public class TaxCollectorMovementRemoveMessage
    {
        public int CollectorId { get; set; }
    }
}