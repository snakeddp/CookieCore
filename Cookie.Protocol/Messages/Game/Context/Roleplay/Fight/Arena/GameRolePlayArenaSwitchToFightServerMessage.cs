
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6575)]
    public class GameRolePlayArenaSwitchToFightServerMessage
    {
        public string Address { get; set; }
        public ushort Port { get; set; }
        [LengthType(typeof(int), true)]
        public byte[] Ticket { get; set; }
    }
}
