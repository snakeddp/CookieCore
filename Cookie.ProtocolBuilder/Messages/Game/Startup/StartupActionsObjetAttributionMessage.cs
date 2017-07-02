namespace Cookie.Protocol.Messages.Game.Startup
{
    [NetworkMessage(1303)]
    public class StartupActionsObjetAttributionMessage
    {
        public uint ActionId { get; set; }

        [CustomVar]
        public long CharacterId { get; set; }
    }
}