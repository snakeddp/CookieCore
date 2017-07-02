using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Tinsel
{
    [NetworkMessage(6373)]
    public class TitleSelectErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}