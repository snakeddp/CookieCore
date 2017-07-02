using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Idol;

namespace Cookie.Protocol.Messages.Game.Idol
{
    [NetworkMessage(6583)]
    public class IdolPartyRefreshMessage
    {
        public PartyIdol PartyIdol { get; set; }
    }
}