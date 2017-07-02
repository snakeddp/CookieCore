namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Stats
{
    [NetworkMessage(5609)]
    public class StatsUpgradeResultMessage
    {
        public byte Result { get; set; }

        [CustomVar]
        public ushort NbCharacBoost { get; set; }
    }
}