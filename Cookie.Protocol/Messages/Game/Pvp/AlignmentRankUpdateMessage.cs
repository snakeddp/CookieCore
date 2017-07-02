using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Pvp
{
    [NetworkMessage(6058)]
    public class AlignmentRankUpdateMessage
    {
        public sbyte AlignmentRank { get; set; }

        [RegularBool]
        public bool Verbose { get; set; }
    }
}