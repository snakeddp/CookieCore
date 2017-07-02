namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(5626)]
    public class QuestListMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] FinishedQuestsIds { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] FinishedQuestsCounts { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] ReinitDoneQuestsIds { get; set; }
    }
}