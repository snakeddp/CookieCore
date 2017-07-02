using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Dare;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6660)]
    public class DareSubscribedMessage
    {
        public double DareId { get; set; }
        public bool Success { get; set; }
        public bool Subscribe { get; set; }
        public DareVersatileInformations DareVersatilesInfos { get; set; }
    }
}