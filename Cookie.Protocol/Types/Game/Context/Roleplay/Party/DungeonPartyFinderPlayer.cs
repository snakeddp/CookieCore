using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Party
{
    [NetworkType(373)]
    public class DungeonPartyFinderPlayer
    {
        [CustomVar]
        public long PlayerId { get; set; }

        public string PlayerName { get; set; }
        public byte Breed { get; set; }

        [RegularBool]
        public bool Sex { get; set; }

        public sbyte Level { get; set; }
    }
}