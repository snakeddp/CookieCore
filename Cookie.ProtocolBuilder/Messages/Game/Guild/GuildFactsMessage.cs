using Cookie.Protocol.Types.Game.Social;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(6415)]
    public class GuildFactsMessage
    {
        public GuildFactSheetInformations Infos { get; set; }
        public uint CreationDate { get; set; }

        [CustomVar]
        public ushort NbTaxCollectors { get; set; }
    }
}