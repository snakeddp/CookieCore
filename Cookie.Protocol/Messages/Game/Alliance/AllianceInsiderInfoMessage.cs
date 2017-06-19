
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Social;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6403)]
    public class AllianceInsiderInfoMessage
    {
        public AllianceFactSheetInformations AllianceInfos { get; set; }
    }
}
