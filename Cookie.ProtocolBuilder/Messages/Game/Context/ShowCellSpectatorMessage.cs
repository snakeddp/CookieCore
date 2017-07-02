namespace Cookie.Protocol.Messages.Game.Context
{
    [NetworkMessage(6158)]
    public class ShowCellSpectatorMessage : ShowCellMessage
    {
        public string PlayerName { get; set; }
    }
}