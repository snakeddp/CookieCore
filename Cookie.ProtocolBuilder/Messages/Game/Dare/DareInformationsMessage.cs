using Cookie.Protocol.Types.Game.Dare;

namespace Cookie.Protocol.Messages.Game.Dare
{
    [NetworkMessage(6656)]
    public class DareInformationsMessage
    {
        public DareInformations DareFixedInfos { get; set; }
        public DareVersatileInformations DareVersatilesInfos { get; set; }
    }
}