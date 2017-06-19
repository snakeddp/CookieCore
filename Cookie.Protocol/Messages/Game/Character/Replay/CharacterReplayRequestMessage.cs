
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Character.Replay
{
    [NetworkMessage(167)]
    public class CharacterReplayRequestMessage
    {
        [CustomVar]
        public long CharacterId { get; set; }
    }
}
