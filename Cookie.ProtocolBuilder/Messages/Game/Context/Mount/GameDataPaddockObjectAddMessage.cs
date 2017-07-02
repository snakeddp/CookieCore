using Cookie.Protocol.Types.Game.Paddock;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5990)]
    public class GameDataPaddockObjectAddMessage
    {
        public PaddockItem PaddockItemDescription { get; set; }
    }
}