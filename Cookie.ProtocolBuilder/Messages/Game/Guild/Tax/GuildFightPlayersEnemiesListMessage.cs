namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5928)]
    public class GuildFightPlayersEnemiesListMessage
    {
        public uint FightId { get; set; }
    }
}