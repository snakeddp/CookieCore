namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5528)]
    public class GameActionFightTeleportOnSameMapMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
        public short CellId { get; set; }
    }
}