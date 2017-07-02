using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6230)]
    public class ShortcutBarSwapRequestMessage
    {
        public sbyte BarType { get; set; }
        public sbyte FirstSlot { get; set; }
        public sbyte SecondSlot { get; set; }
    }
}