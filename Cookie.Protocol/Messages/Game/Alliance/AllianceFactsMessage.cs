
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Social;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6414)]
    public class AllianceFactsMessage
    {
        public AllianceFactSheetInformations Infos { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] ControlledSubareaIds { get; set; }
        [CustomVar]
        public long LeaderCharacterId { get; set; }
        public string LeaderCharacterName { get; set; }
    }
}
