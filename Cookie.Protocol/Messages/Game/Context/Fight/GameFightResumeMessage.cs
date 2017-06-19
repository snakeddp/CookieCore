
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Fight;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6067)]
    public class GameFightResumeMessage : GameFightSpectateMessage
    {
        public sbyte SummonCount { get; set; }
        public sbyte BombCount { get; set; }
    }
}
