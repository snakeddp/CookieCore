using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5717)]
    public class GuildFightJoinRequestMessage
    {
        public int TaxCollectorId { get; set; }
    }
}