
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;
using Cookie.Protocol.Types.Game.Character.Characteristic;
using Cookie.Protocol.Types.Game.Shortcut;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(6214)]
    public class SlaveSwitchContextMessage
    {
        public double MasterId { get; set; }
        public double SlaveId { get; set; }
        public CharacterCharacteristicsInformations SlaveStats { get; set; }
    }
}
