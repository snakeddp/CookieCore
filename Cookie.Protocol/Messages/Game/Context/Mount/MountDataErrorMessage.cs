using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(6172)]
    public class MountDataErrorMessage
    {
        public sbyte Reason { get; set; }
    }
}