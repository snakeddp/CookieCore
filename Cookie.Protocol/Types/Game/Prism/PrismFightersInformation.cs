
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Fight;
using Cookie.Protocol.Types.Game.Character;
using Cookie.Protocol.Types.Game.Character;

namespace Cookie.Protocol.Types.Game.Prism
{
    [NetworkType(443)]
    public class PrismFightersInformation
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }
        public ProtectedEntityWaitingForHelpInfo WaitingForHelpInfo { get; set; }
    }
}
