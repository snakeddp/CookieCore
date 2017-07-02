namespace Cookie.Protocol.Messages.Game.Report
{
    [NetworkMessage(6079)]
    public class CharacterReportMessage
    {
        [CustomVar]
        public long ReportedId { get; set; }

        public sbyte Reason { get; set; }
    }
}