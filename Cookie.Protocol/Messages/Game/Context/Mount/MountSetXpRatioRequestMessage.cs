
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5989)]
    public class MountSetXpRatioRequestMessage
    {
        public sbyte XpRatio { get; set; }
    }
}
