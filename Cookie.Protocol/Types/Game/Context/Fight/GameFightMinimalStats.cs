using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;

namespace Cookie.Protocol.Types.Game.Context.Fight
{
    [NetworkType(31)]
    public class GameFightMinimalStats
    {
        [CustomVar]
        public uint LifePoints { get; set; }

        [CustomVar]
        public uint MaxLifePoints { get; set; }

        [CustomVar]
        public uint BaseMaxLifePoints { get; set; }

        [CustomVar]
        public uint PermanentDamagePercent { get; set; }

        [CustomVar]
        public uint ShieldPoints { get; set; }

        [CustomVar]
        public short ActionPoints { get; set; }

        [CustomVar]
        public short MaxActionPoints { get; set; }

        [CustomVar]
        public short MovementPoints { get; set; }

        [CustomVar]
        public short MaxMovementPoints { get; set; }

        public double Summoner { get; set; }

        [RegularBool]
        public bool Summoned { get; set; }

        [CustomVar]
        public short NeutralElementResistPercent { get; set; }

        [CustomVar]
        public short EarthElementResistPercent { get; set; }

        [CustomVar]
        public short WaterElementResistPercent { get; set; }

        [CustomVar]
        public short AirElementResistPercent { get; set; }

        [CustomVar]
        public short FireElementResistPercent { get; set; }

        [CustomVar]
        public short NeutralElementReduction { get; set; }

        [CustomVar]
        public short EarthElementReduction { get; set; }

        [CustomVar]
        public short WaterElementReduction { get; set; }

        [CustomVar]
        public short AirElementReduction { get; set; }

        [CustomVar]
        public short FireElementReduction { get; set; }

        [CustomVar]
        public short CriticalDamageFixedResist { get; set; }

        [CustomVar]
        public short PushDamageFixedResist { get; set; }

        [CustomVar]
        public short PvpNeutralElementResistPercent { get; set; }

        [CustomVar]
        public short PvpEarthElementResistPercent { get; set; }

        [CustomVar]
        public short PvpWaterElementResistPercent { get; set; }

        [CustomVar]
        public short PvpAirElementResistPercent { get; set; }

        [CustomVar]
        public short PvpFireElementResistPercent { get; set; }

        [CustomVar]
        public short PvpNeutralElementReduction { get; set; }

        [CustomVar]
        public short PvpEarthElementReduction { get; set; }

        [CustomVar]
        public short PvpWaterElementReduction { get; set; }

        [CustomVar]
        public short PvpAirElementReduction { get; set; }

        [CustomVar]
        public short PvpFireElementReduction { get; set; }

        [CustomVar]
        public ushort DodgePALostProbability { get; set; }

        [CustomVar]
        public ushort DodgePMLostProbability { get; set; }

        [CustomVar]
        public short TackleBlock { get; set; }

        [CustomVar]
        public short TackleEvade { get; set; }

        [CustomVar]
        public short FixedDamageReflection { get; set; }

        public sbyte InvisibilityState { get; set; }

        [CustomVar]
        public ushort MeleeDamageReceivedPercent { get; set; }

        [CustomVar]
        public ushort RangedDamageReceivedPercent { get; set; }

        [CustomVar]
        public ushort WeaponDamageReceivedPercent { get; set; }

        [CustomVar]
        public ushort SpellDamageReceivedPercent { get; set; }
    }
}