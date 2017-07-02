namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(6235)]
    public class GuildFightTakePlaceRequestMessage : GuildFightJoinRequestMessage
    {
        public int ReplacedCharacterId { get; set; }
    }
}