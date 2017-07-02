namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(5618)]
    public class NpcDialogCreationMessage
    {
        public int MapId { get; set; }
        public int NpcId { get; set; }
    }
}