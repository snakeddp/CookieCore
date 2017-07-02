namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5699)]
    public class GuildSpellUpgradeRequestMessage
    {
        public uint SpellId { get; set; }
    }
}