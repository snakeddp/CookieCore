namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Stats
{
    [NetworkMessage(5610)]
    public class StatsUpgradeRequestMessage
    {
        [RegularBool]
        public bool UseAdditionnal { get; set; }

        public sbyte StatId { get; set; }

        [CustomVar]
        public ushort BoostPoint { get; set; }
    }
}