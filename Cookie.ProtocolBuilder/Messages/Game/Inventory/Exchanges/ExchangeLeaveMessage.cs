namespace Cookie.Protocol.Messages.Game.Inventory.Exchanges
{
    [NetworkMessage(5628)]
    public class ExchangeLeaveMessage : LeaveDialogMessage
    {
        [RegularBool]
        public bool Success { get; set; }
    }
}