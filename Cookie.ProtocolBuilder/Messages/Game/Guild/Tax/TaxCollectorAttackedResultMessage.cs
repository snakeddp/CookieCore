using Cookie.Protocol.Types.Game.Context.Roleplay;
using Cookie.Protocol.Types.Game.Guild.Tax;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5635)]
    public class TaxCollectorAttackedResultMessage
    {
        [RegularBool]
        public bool DeadOrAlive { get; set; }

        public TaxCollectorBasicInformations BasicInfos { get; set; }
        public BasicGuildInformations Guild { get; set; }
    }
}