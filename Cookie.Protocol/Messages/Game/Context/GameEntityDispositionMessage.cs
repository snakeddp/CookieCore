
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(5693)]
    public class GameEntityDispositionMessage
    {
        public IdentifiedEntityDispositionInformations Disposition { get; set; }
    }
}
