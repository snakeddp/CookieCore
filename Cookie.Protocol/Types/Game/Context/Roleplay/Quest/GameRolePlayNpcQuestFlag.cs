
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Roleplay.Quest
{
    [NetworkType(384)]
    public class GameRolePlayNpcQuestFlag
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] QuestsToValidId { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] QuestsToStartId { get; set; }
    }
}
