using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6526)]
    public class SymbioticObjectErrorMessage : ObjectErrorMessage
    {
        public byte ErrorCode { get; set; }
    }
}