using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Emote
{
    [NetworkMessage(5691)]
    public class EmotePlayMassiveMessage : EmotePlayAbstractMessage
    {
        [LengthType(typeof(short), true)]
        public double[] ActorIds { get; set; }
    }
}