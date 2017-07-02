using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(946)]
    public class GameMapChangeOrientationMessage
    {
        public ActorOrientation Orientation { get; set; }
    }
}