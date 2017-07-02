using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(5583)]
    public class PartyCannotJoinErrorMessage : AbstractPartyMessage
    {
        public sbyte Reason { get; set; }
    }
}