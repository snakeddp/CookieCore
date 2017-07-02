using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Messages.Game.Dialog;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5628)]
    public class ExchangeLeaveMessage : LeaveDialogMessage
    {
        [RegularBool]
        public bool Success { get; set; }
    }
}