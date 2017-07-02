using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(5750)]
    public class MapRunningFightDetailsRequestMessage
    {
        public uint FightId { get; set; }
    }
}