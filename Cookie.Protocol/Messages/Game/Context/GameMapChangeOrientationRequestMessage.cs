using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(945)]
    public class GameMapChangeOrientationRequestMessage
    {
        public sbyte Direction { get; set; }
    }
}