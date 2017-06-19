
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Messages.Game.Guild
{
    [NetworkMessage(5636)]
    public class GuildInfosUpgradeMessage
    {
        public sbyte MaxTaxCollectorsCount { get; set; }
        public sbyte TaxCollectorsCount { get; set; }
        [CustomVar]
        public ushort TaxCollectorLifePoints { get; set; }
        [CustomVar]
        public ushort TaxCollectorDamagesBonuses { get; set; }
        [CustomVar]
        public ushort TaxCollectorPods { get; set; }
        [CustomVar]
        public ushort TaxCollectorProspecting { get; set; }
        [CustomVar]
        public ushort TaxCollectorWisdom { get; set; }
        [CustomVar]
        public ushort BoostPoints { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] SpellId { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public short[] SpellLevel { get; set; }
    }
}
