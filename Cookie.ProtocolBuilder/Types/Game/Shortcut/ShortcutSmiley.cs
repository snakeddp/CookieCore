namespace Cookie.Protocol.Types.Game.Shortcut
{
    [NetworkType(388)]
    public class ShortcutSmiley : Shortcut
    {
        [CustomVar]
        public ushort SmileyId { get; set; }
    }
}