using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Atlas.Compass
{
    [NetworkMessage(5584)]
    public class CompassResetMessage
    {
        public sbyte Type { get; set; }
    }
}