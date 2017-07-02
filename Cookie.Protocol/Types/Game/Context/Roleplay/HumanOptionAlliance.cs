using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(425)]
    public class HumanOptionAlliance : HumanOption
    {
        public AllianceInformations AllianceInformations { get; set; }
        public sbyte Aggressable { get; set; }
    }
}