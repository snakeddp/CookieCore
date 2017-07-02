namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Spell
{
    [NetworkMessage(6011)]
    public class SpellItemBoostMessage
    {
        [CustomVar]
        public uint StatId { get; set; }

        [CustomVar]
        public ushort SpellId { get; set; }

        [CustomVar]
        public short Value { get; set; }
    }
}