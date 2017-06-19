
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Character.Choice
{
    [NetworkType(474)]
    public class CharacterHardcoreOrEpicInformations : CharacterBaseInformations
    {
        public sbyte DeathState { get; set; }
        [CustomVar]
        public ushort DeathCount { get; set; }
        public sbyte DeathMaxLevel { get; set; }
    }
}
