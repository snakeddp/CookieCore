
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(6056)]
    public class ExchangeMountSterilizeFromPaddockMessage
    {
        public string Name { get; set; }
        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public string Sterilizator { get; set; }
    }
}
