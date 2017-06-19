
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(251)]
    public class GameContextRemoveElementMessage
    {
        public double Id { get; set; }
    }
}
