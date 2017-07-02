namespace Cookie.Protocol.Messages.Game.Inventory.Spells
{
    [NetworkMessage(1200)]
    public class SpellListMessage
    {
        [RegularBool]
        public bool SpellPrevisualization { get; set; }
    }
}