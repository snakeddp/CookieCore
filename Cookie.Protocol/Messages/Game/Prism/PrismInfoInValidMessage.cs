
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(5859)]
    public class PrismInfoInValidMessage
    {
        public sbyte Reason { get; set; }
    }
}
