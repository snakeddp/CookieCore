namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(5741)]
    public class GameActionFightTriggerGlyphTrapMessage : AbstractGameActionMessage
    {
        public short MarkId { get; set; }
        public double TriggeringCharacterId { get; set; }

        [CustomVar]
        public ushort TriggeredSpellId { get; set; }
    }
}