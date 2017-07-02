namespace Cookie.Protocol.Messages.Game.Context.Roleplay
{
    [NetworkMessage(210)]
    public class MapFightCountMessage
    {
        [CustomVar]
        public ushort FightCount { get; set; }
    }
}