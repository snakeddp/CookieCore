using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(24)]
    public class FightResultPlayerListEntry : FightResultFighterListEntry
    {
        public sbyte Level { get; set; }
    }
}