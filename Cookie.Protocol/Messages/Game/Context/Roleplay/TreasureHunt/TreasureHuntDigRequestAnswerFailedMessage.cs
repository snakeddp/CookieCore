
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    [NetworkMessage(6509)]
    public class TreasureHuntDigRequestAnswerFailedMessage : TreasureHuntDigRequestAnswerMessage
    {
        public sbyte WrongFlagCount { get; set; }
    }
}
