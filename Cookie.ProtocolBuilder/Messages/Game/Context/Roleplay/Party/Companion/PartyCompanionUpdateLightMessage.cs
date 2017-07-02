namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party.Companion
{
    [NetworkMessage(6472)]
    public class PartyCompanionUpdateLightMessage : PartyUpdateLightMessage
    {
        public sbyte IndexId { get; set; }
    }
}