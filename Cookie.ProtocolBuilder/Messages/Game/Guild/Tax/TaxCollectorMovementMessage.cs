using Cookie.Protocol.Types.Game.Guild.Tax;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5633)]
    public class TaxCollectorMovementMessage
    {
        public sbyte MovementType { get; set; }
        public TaxCollectorBasicInformations BasicInfos { get; set; }

        [CustomVar]
        public long PlayerId { get; set; }

        public string PlayerName { get; set; }
    }
}