
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5993)]
    public class GameDataPaddockObjectRemoveMessage
    {
        [CustomVar]
        public ushort CellId { get; set; }
    }
}
