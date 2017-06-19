
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Guild.Tax;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5917)]
    public class TaxCollectorMovementAddMessage
    {
        public TaxCollectorInformations Informations { get; set; }
    }
}
