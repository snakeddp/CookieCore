
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(707)]
    public class GameFightOptionToggleMessage
    {
        public sbyte Option { get; set; }
    }
}
