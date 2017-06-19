
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight.Challenge
{
    [NetworkMessage(6123)]
    public class ChallengeTargetUpdateMessage
    {
        [CustomVar]
        public ushort ChallengeId { get; set; }
        public double TargetId { get; set; }
    }
}
