namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6575)]
    public class GameRolePlayArenaSwitchToFightServerMessage
    {
        public string Address { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Ports { get; set; }

        [LengthType(typeof(int), true)]
        public byte[] Ticket { get; set; }
    }
}