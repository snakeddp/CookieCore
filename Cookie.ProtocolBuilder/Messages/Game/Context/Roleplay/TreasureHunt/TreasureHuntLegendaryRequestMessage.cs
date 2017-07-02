namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6499)]
    public class TreasureHuntLegendaryRequestMessage
    {
        [CustomVar]
        public ushort LegendaryId { get; set; }
    }
}