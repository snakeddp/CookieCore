namespace Cookie.Protocol.Messages.Game.Context.Dungeon
{
    [NetworkMessage(6299)]
    public class DungeonKeyRingMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Availables { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Unavailables { get; set; }
    }
}