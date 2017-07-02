namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6219)]
    public class GameActionFightSpellCooldownVariationMessage : AbstractGameActionMessage
    {
        public double TargetId { get; set; }

        [CustomVar]
        public ushort SpellId { get; set; }

        [CustomVar]
        public short Value { get; set; }
    }
}