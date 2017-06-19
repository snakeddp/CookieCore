
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5970)]
    public class MountXpRatioMessage
    {
        public sbyte Ratio { get; set; }
    }
}
