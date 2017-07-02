namespace Cookie.Protocol.Types.Game.Context.Roleplay.Quest
{
    [NetworkType(381)]
    public class QuestActiveInformations
    {
        [CustomVar]
        public ushort QuestId { get; set; }
    }
}