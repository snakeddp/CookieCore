namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5531)]
    public class GameActionFightReflectSpellMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }
    }
}