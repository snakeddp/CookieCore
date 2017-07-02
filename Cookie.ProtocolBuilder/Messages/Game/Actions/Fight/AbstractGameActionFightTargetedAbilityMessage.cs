namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6118)]
    public class AbstractGameActionFightTargetedAbilityMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short DestinationCellId { get; set; }
        public sbyte Critical { get; set; }
        public bool SilentCast { get; set; }
        public bool VerboseCast { get; set; }
    }
}