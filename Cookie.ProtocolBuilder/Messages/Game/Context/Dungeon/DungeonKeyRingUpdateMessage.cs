namespace Cookie.Protocol.Messages.Game.Context.Dungeon
{
    [NetworkMessage(6296)]
    public class DungeonKeyRingUpdateMessage
    {
        [CustomVar]
        public ushort DungeonId { get; set; }

        [RegularBool]
        public bool Available { get; set; }
    }
}