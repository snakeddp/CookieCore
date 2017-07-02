using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    [NetworkMessage(6141)]
    public class PaddockToSellListRequestMessage
    {
        [CustomVar]
        public ushort PageIndex { get; set; }
    }
}