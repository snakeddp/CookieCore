using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6370)]
    public class OrnamentSelectErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}