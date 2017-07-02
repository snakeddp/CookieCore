namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Fight.Arena
{
    [NetworkMessage(6574)]
    public class GameRolePlayArenaSwitchToGameServerMessage
    {
        [RegularBool]
        public bool ValidToken { get; set; }

        [LengthType(typeof(int), true)]
        public byte[] Ticket { get; set; }

        public short HomeServerId { get; set; }
    }
}