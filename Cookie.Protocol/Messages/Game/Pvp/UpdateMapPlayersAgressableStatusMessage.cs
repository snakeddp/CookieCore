using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Pvp
{
    [NetworkMessage(6454)]
    public class UpdateMapPlayersAgressableStatusMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public long[] PlayerIds { get; set; }

        [LengthType(typeof(short), true)]
        public sbyte[] Enable { get; set; }
    }
}