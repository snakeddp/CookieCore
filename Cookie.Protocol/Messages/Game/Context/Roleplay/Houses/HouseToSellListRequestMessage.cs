using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Houses
{
    [NetworkMessage(6139)]
    public class HouseToSellListRequestMessage
    {
        [CustomVar]
        public ushort PageIndex { get; set; }
    }
}