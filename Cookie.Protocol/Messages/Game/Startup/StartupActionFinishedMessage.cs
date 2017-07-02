using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Startup
{
    [NetworkMessage(1304)]
    public class StartupActionFinishedMessage
    {
        public bool Success { get; set; }
        public uint ActionId { get; set; }
        public bool AutomaticAction { get; set; }
    }
}