using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(210)]
    public class FightTriggeredEffect : AbstractFightDispellableEffect
    {
        public int Param1 { get; set; }
        public int Param2 { get; set; }
        public int Param3 { get; set; }
        public short Delay { get; set; }
    }
}