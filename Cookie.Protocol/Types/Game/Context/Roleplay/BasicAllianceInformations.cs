using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Social;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(419)]
    public class BasicAllianceInformations : AbstractSocialGroupInfos
    {
        [CustomVar]
        public uint AllianceId { get; set; }

        public string AllianceTag { get; set; }
    }
}