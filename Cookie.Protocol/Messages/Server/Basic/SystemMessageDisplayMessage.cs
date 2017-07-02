using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Server.Basic
{
    [NetworkMessage(189)]
    public class SystemMessageDisplayMessage
    {
        [RegularBool]
        public bool HangUp { get; set; }

        [CustomVar]
        public ushort MsgId { get; set; }

        [LengthType(typeof(short), true)]
        public string[] Parameters { get; set; }
    }
}