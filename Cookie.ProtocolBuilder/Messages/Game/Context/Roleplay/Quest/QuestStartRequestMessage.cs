namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(5643)]
    public class QuestStartRequestMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }
    }
}