using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(413)]
    public class GameFightFighterLightInformations
    {
        public double Id { get; set; }
        public sbyte Wave { get; set; }

        [CustomVar]
        public ushort Level { get; set; }

        public byte Breed { get; set; }
        public bool Sex { get; set; }
        public bool Alive { get; set; }
    }
}