
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(708)]
    public class GameFightReadyMessage
    {
        [RegularBool]
        public bool IsReady { get; set; }
    }
}
