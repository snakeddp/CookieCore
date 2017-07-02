namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5715)]
    public class GuildFightLeaveRequestMessage
    {
        public uint TaxCollectorId { get; set; }

        [CustomVar]
        public long CharacterId { get; set; }
    }
}