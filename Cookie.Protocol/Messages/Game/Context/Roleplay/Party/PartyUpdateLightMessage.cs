
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Party
{
    [NetworkMessage(6054)]
    public class PartyUpdateLightMessage : AbstractPartyEventMessage
    {
        [CustomVar]
        public long Id { get; set; }
        [CustomVar]
        public uint LifePoints { get; set; }
        [CustomVar]
        public uint MaxLifePoints { get; set; }
        [CustomVar]
        public ushort Prospecting { get; set; }
        public sbyte RegenRate { get; set; }
    }
}
