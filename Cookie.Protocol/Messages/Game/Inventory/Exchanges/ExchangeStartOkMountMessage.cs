
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Mount;

namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5979)]
    public class ExchangeStartOkMountMessage : ExchangeStartOkMountWithOutPaddockMessage
    {
    }
}
