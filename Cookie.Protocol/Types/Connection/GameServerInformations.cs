using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Connection
{
    [NetworkType(25)]
    public class GameServerInformations
    {
        [CustomVar]
        public ushort Id { get; set; }

        public byte Type { get; set; }
        public sbyte Status { get; set; }
        public sbyte Completion { get; set; }

        [RegularBool]
        public bool IsSelectable { get; set; }

        public sbyte CharactersCount { get; set; }
        public sbyte CharactersSlots { get; set; }
        public double Date { get; set; }
    }
}