
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Look;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(144)]
    public class MonsterInGroupInformations : MonsterInGroupLightInformations
    {
        public EntityLook Look { get; set; }
    }
}
