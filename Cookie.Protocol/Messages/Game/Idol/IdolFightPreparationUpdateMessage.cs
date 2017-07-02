using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Idol
{
    [NetworkMessage(6586)]
    public class IdolFightPreparationUpdateMessage
    {
        public sbyte IdolSource { get; set; }
    }
}