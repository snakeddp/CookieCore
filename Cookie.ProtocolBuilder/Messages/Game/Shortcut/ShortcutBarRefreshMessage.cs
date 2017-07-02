namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6229)]
    public class ShortcutBarRefreshMessage
    {
        public sbyte BarType { get; set; }
        public Shortcut Shortcut { get; set; }
    }
}