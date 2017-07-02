namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6706)]
    public class ShortcutBarReplacedMessage
    {
        public sbyte BarType { get; set; }
        public Shortcut Shortcut { get; set; }
    }
}