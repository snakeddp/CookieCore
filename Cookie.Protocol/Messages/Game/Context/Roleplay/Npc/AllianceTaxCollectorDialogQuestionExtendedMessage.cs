
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(6445)]
    public class AllianceTaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionExtendedMessage
    {
        public BasicNamedAllianceInformations Alliance { get; set; }
    }
}
