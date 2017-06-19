
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(140)]
    public class GroupMonsterStaticInformations
    {
        public MonsterInGroupLightInformations MainCreatureLightInfos { get; set; }
    }
}
