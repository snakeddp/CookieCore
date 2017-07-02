using Cookie.Core.Attributes.Class;

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