using Cookie.Protocol.Types.Game.Social;

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