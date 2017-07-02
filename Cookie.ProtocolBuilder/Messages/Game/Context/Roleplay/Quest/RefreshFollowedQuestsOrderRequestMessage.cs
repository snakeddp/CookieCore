namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Quest
{
    [NetworkMessage(6722)]
    public class RefreshFollowedQuestsOrderRequestMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Quests { get; set; }
    }
}