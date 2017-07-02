namespace Cookie.Protocol.Messages.Game.Basic
{
    [NetworkMessage(780)]
    public class TextInformationMessage
    {
        public sbyte MsgType { get; set; }

        [CustomVar]
        public ushort MsgId { get; set; }

        [LengthType(typeof(short), true)]
        public string[] Parameters { get; set; }
    }
}