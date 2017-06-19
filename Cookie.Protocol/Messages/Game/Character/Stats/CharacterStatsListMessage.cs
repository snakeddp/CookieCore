
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character.Characteristic;

namespace Cookie.Protocol.Messages.Game.Character.Stats
{
    [NetworkMessage(500)]
    public class CharacterStatsListMessage
    {
        public CharacterCharacteristicsInformations Stats { get; set; }
    }
}
