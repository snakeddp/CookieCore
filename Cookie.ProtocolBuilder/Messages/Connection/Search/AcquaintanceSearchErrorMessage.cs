namespace Cookie.Protocol.Messages.Connection.Search
{
    [NetworkMessage(6143)]
    public class AcquaintanceSearchErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}