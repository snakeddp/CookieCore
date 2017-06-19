
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight.Challenge
{
    [NetworkMessage(5614)]
    public class ChallengeTargetsListRequestMessage
    {
        [CustomVar]
        public ushort ChallengeId { get; set; }
    }
}
