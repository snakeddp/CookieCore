namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6492)]
    public class PortalUseRequestMessage
    {
        [CustomVar]
        public uint PortalId { get; set; }
    }
}