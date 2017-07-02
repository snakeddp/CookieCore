namespace Cookie.Protocol.Messages.Game.Actions.Fight
{
    [NetworkMessage(6176)]
    public class GameActionFightDispellSpellMessage : GameActionFightDispellMessage
    {
        [CustomVar]
        public ushort SpellId { get; set; }
    }
}