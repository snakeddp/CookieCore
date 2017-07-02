namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(5663)]
    public class BasicLatencyStatsMessage
    {
        public ushort Latency { get; set; }

        [CustomVar]
        public ushort SampleCount { get; set; }

        [CustomVar]
        public ushort Max { get; set; }
    }
}