using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight
{
    [NetworkMessage(5731)]
    public class GameRolePlayPlayerFightRequestMessage
    {
        [CustomVar]
        public long TargetId { get; set; }

        public short TargetCellId { get; set; }

        [RegularBool]
        public bool Friendly { get; set; }
    }
}