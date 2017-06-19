
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Fight;
using Cookie.Protocol.Types.Game.Context.Roleplay.Party;

namespace Cookie.Protocol.Messages.Game.Context.Fight
{
    [NetworkMessage(720)]
    public class GameFightEndMessage
    {
        public uint Duration { get; set; }
        public short AgeBonus { get; set; }
        public short LootShareLimitMalus { get; set; }
    }
}
