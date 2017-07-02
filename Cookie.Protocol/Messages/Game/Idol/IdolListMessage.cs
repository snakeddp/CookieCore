using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Idol
{
    [NetworkMessage(6585)]
    public class IdolListMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] ChosenIdols { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] PartyChosenIdols { get; set; }
    }
}