using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(5751)]
    public class MapRunningFightDetailsMessage
    {
        public uint FightId { get; set; }
    }
}