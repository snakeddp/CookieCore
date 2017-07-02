namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Visual
{
    [NetworkMessage(6114)]
    public class GameRolePlaySpellAnimMessage
    {
        [CustomVar]
        public long CasterId { get; set; }

        [CustomVar]
        public ushort TargetCellId { get; set; }

        [CustomVar]
        public ushort SpellId { get; set; }

        public short SpellLevel { get; set; }
    }
}