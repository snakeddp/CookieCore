
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Character.Characteristic;

namespace Cookie.Protocol.Messages.Game.Character.Stats
{
    [NetworkMessage(6322)]
    public class FighterStatsListMessage
    {
        public CharacterCharacteristicsInformations Stats { get; set; }
    }
}
