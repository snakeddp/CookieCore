
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Friend
{
    [NetworkType(105)]
    public class IgnoredOnlineInformations : IgnoredInformations
    {
        [CustomVar]
        public long PlayerId { get; set; }
        public string PlayerName { get; set; }
        public byte Breed { get; set; }
        [RegularBool]
        public bool Sex { get; set; }
    }
}
