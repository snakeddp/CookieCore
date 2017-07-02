namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5959)]
    public class GuildInformationsPaddocksMessage
    {
        public sbyte NbPaddockMax { get; set; }
    }
}