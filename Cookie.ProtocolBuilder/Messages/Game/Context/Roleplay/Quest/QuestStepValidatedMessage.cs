namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6099)]
    public class QuestStepValidatedMessage
    {
        [CustomVar]
        public ushort QuestId { get; set; }

        [CustomVar]
        public ushort StepId { get; set; }
    }
}