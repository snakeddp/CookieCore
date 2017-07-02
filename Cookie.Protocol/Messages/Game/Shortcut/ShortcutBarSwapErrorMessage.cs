using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Shortcut
{
    [NetworkMessage(6226)]
    public class ShortcutBarSwapErrorMessage
    {
        public sbyte Error { get; set; }
    }
}