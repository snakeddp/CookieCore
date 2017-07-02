using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight.Challenge
{
    [NetworkMessage(6019)]
    public class ChallengeResultMessage
    {
        [CustomVar]
        public ushort ChallengeId { get; set; }

        [RegularBool]
        public bool Success { get; set; }
    }
}