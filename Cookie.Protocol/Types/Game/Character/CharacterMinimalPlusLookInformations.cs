using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Character
{
    [NetworkType(163)]
    public class CharacterMinimalPlusLookInformations : CharacterMinimalInformations
    {
        public EntityLook EntityLook { get; set; }
    }
}