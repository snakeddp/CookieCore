using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(407)]
    public class HumanOptionEmote : HumanOption
    {
        public sbyte EmoteId { get; set; }
        public double EmoteStartTime { get; set; }
    }
}