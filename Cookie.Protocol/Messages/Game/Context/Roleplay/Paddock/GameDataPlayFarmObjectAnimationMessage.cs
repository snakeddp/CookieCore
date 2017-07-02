using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    [NetworkMessage(6026)]
    public class GameDataPlayFarmObjectAnimationMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] CellId { get; set; }
    }
}