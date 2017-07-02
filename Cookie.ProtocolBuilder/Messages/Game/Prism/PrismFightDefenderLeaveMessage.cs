namespace Cookie.Protocol.Messages.Game.Prism
{
    [NetworkMessage(5892)]
    public class PrismFightDefenderLeaveMessage
    {
        [CustomVar]
        public ushort SubAreaId { get; set; }

        [CustomVar]
        public ushort FightId { get; set; }

        [CustomVar]
        public long FighterToRemoveId { get; set; }
    }
}