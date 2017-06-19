
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6675)]
    public class DareRewardConsumeValidationMessage
    {
        public double DareId { get; set; }
        public sbyte Type { get; set; }
    }
}
