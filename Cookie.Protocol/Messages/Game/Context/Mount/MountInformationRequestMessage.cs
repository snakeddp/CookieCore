using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5972)]
    public class MountInformationRequestMessage
    {
        public double Id { get; set; }
        public double Time { get; set; }
    }
}