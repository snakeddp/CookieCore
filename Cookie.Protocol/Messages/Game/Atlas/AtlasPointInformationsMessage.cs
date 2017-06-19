
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Atlas
{
    [NetworkMessage(5956)]
    public class AtlasPointInformationsMessage
    {
        public AtlasPointsInformations Type { get; set; }
    }
}
