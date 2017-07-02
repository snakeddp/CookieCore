using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Data.Items;

namespace Cookie.Protocol.Messages.Game.Inventory.Items
{
    [NetworkMessage(6458)]
    public class MimicryObjectPreviewMessage
    {
        public ObjectItem Result { get; set; }
    }
}