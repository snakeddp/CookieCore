namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6227)]
    public class ShortcutBarAddErrorMessage
    {
        public sbyte Error { get; set; }
    }
}