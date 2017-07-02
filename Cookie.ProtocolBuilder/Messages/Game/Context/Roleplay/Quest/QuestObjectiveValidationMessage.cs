namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6085)]
    public class QuestObjectiveValidationMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }

        [CustomVar]
        public ushort ObjectiveId { get; set; }
    }
}