using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight.Challenge
{
    [NetworkMessage(6022)]
    public class ChallengeInfoMessage
    {
        [CustomVar]
        public ushort ChallengeId { get; set; }

        public double TargetId { get; set; }

        [CustomVar]
        public uint XpBonus { get; set; }

        [CustomVar]
        public uint DropBonus { get; set; }
    }
}