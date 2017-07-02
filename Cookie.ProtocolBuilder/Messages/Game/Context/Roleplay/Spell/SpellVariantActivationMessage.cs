namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Spell
{
    [NetworkMessage(6705)]
    public class SpellVariantActivationMessage
    {
        [RegularBool]
        public bool Result { get; set; }

        [CustomVar]
        public ushort ActivatedSpellId { get; set; }

        [CustomVar]
        public ushort DeactivatedSpellId { get; set; }
    }
}