namespace Cookie.Protocol.Messages.Debug
{
    [NetworkMessage(2001)]
    public class DebugHighlightCellsMessage
    {
        public int Color { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] Cells { get; set; }
    }
}