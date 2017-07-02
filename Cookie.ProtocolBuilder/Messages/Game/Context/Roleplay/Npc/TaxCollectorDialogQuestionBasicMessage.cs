using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Npc
{
    [NetworkMessage(5619)]
    public class TaxCollectorDialogQuestionBasicMessage
    {
        public BasicGuildInformations GuildInfo { get; set; }
    }
}