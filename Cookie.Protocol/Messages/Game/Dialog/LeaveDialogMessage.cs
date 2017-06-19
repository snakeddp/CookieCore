
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Dialog
{
    [NetworkMessage(5502)]
    public class LeaveDialogMessage
    {
        public sbyte DialogType { get; set; }
    }
}
