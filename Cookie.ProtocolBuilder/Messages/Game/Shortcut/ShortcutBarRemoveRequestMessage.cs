namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6228)]
    public class ShortcutBarRemoveRequestMessage
    {
        public sbyte BarType { get; set; }
        public sbyte Slot { get; set; }
    }
}