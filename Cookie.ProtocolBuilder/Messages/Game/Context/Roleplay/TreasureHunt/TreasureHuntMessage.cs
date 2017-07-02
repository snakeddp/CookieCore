namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6486)]
    public class TreasureHuntMessage
    {
        public sbyte QuestType { get; set; }
        public int StartMapId { get; set; }
        public sbyte TotalStepCount { get; set; }

        [CustomVar]
        public uint CheckPointCurrent { get; set; }

        [CustomVar]
        public uint CheckPointTotal { get; set; }

        public int AvailableRetryCount { get; set; }
    }
}