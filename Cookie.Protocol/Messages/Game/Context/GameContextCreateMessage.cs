using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(200)]
    public class GameContextCreateMessage
    {
        public sbyte Context { get; set; }
    }
}