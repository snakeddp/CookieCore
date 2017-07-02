namespace Cookie.Protocol.Types.Game.Shortcut
{
    [NetworkType(368)]
    public class ShortcutSpell : Shortcut
    {
        [CustomVar]
        public ushort SpellId { get; set; }
    }
}