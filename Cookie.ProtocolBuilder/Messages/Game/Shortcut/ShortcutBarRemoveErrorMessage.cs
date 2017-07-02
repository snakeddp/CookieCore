namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6222)]
    public class ShortcutBarRemoveErrorMessage
    {
        public sbyte Error { get; set; }
    }
}