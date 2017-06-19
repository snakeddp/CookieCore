
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(425)]
    public class HumanOptionAlliance : HumanOption
    {
        public AllianceInformations AllianceInformations { get; set; }
        public sbyte Aggressable { get; set; }
    }
}
