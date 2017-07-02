using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5762)]
    public class ExchangeGuildTaxCollectorGetMessage
    {
        public string CollectorName { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        public string UserName { get; set; }

        [CustomVar]
        public long CallerId { get; set; }

        public string CallerName { get; set; }
        public double Experience { get; set; }

        [CustomVar]
        public ushort Pods { get; set; }
    }
}