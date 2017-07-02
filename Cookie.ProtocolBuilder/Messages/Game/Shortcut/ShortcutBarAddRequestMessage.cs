namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6225)]
    public class ShortcutBarAddRequestMessage
    {
        public sbyte BarType { get; set; }
        public Shortcut Shortcut { get; set; }
    }
}