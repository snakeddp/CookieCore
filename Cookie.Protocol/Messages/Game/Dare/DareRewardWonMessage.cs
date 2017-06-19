
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Dare;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6678)]
    public class DareRewardWonMessage
    {
        public DareReward Reward { get; set; }
    }
}
