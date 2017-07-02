namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Spell
{
    [NetworkMessage(6707)]
    public class SpellVariantActivationRequestMessage
    {
        [CustomVar]
        public ushort SpellId { get; set; }
    }
}