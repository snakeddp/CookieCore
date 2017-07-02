namespace Cookie.Protocol.Types.Game.Fight
{
    [NetworkType(186)]
    public class ProtectedEntityWaitingForHelpInfo
    {
        public int TimeLeftBeforeFight { get; set; }
        public int WaitTimeForPlacement { get; set; }
        public sbyte NbPositionForDefensors { get; set; }
    }
}