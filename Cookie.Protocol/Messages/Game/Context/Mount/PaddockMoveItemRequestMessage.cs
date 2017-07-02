using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(6052)]
    public class PaddockMoveItemRequestMessage
    {
        [CustomVar]
        public ushort OldCellId { get; set; }

        [CustomVar]
        public ushort NewCellId { get; set; }
    }
}