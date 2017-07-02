using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6676)]
    public class DareRewardConsumeRequestMessage
    {
        public double DareId { get; set; }
        public sbyte Type { get; set; }
    }
}