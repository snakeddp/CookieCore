
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Fight;
using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(5751)]
    public class MapRunningFightDetailsMessage
    {
        public uint FightId { get; set; }
    }
}
