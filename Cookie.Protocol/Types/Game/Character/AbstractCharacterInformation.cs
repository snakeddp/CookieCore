using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Character
{
    [NetworkType(400)]
    public class AbstractCharacterInformation
    {
        [CustomVar]
        public long Id { get; set; }
    }
}