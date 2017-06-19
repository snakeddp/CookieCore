
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Dare;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6665)]
    public class DareCreationRequestMessage
    {
        [CustomVar]
        public long SubscriptionFee { get; set; }
        [CustomVar]
        public long Jackpot { get; set; }
        public ushort MaxCountWinners { get; set; }
        public uint DelayBeforeStart { get; set; }
        public uint Duration { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsForGuild { get; set; }
        public bool IsForAlliance { get; set; }
        public bool NeedNotifications { get; set; }
    }
}
