
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Purchasable
{
    [NetworkMessage(5739)]
    public class PurchasableDialogMessage
    {
        public bool BuyOrSell { get; set; }
        [CustomVar]
        public uint PurchasableId { get; set; }
        public uint PurchasableInstanceId { get; set; }
        public bool SecondHand { get; set; }
        [CustomVar]
        public long Price { get; set; }
    }
}
