using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Character.Alignment;

namespace Cookie.Protocol.Types.Game.Character.Characteristic
{
    [NetworkType(8)]
    public class CharacterCharacteristicsInformations
    {
        [CustomVar]
        public long Experience { get; set; }

        [CustomVar]
        public long ExperienceLevelFloor { get; set; }

        [CustomVar]
        public long ExperienceNextLevelFloor { get; set; }

        [CustomVar]
        public long ExperienceBonusLimit { get; set; }

        [CustomVar]
        public long Kamas { get; set; }

        [CustomVar]
        public ushort StatsPoints { get; set; }

        [CustomVar]
        public ushort AdditionnalPoints { get; set; }

        [CustomVar]
        public ushort SpellsPoints { get; set; }

        public ActorExtendedAlignmentInformations AlignmentInfos { get; set; }

        [CustomVar]
        public uint LifePoints { get; set; }

        [CustomVar]
        public uint MaxLifePoints { get; set; }

        [CustomVar]
        public ushort EnergyPoints { get; set; }

        [CustomVar]
        public ushort MaxEnergyPoints { get; set; }

        [CustomVar]
        public short ActionPointsCurrent { get; set; }

        [CustomVar]
        public short MovementPointsCurrent { get; set; }

        public CharacterBaseCharacteristic Initiative { get; set; }
        public CharacterBaseCharacteristic Prospecting { get; set; }
        public CharacterBaseCharacteristic ActionPoints { get; set; }
        public CharacterBaseCharacteristic MovementPoints { get; set; }
        public CharacterBaseCharacteristic Strength { get; set; }
        public CharacterBaseCharacteristic Vitality { get; set; }
        public CharacterBaseCharacteristic Wisdom { get; set; }
        public CharacterBaseCharacteristic Chance { get; set; }
        public CharacterBaseCharacteristic Agility { get; set; }
        public CharacterBaseCharacteristic Intelligence { get; set; }
        public CharacterBaseCharacteristic Range { get; set; }
        public CharacterBaseCharacteristic SummonableCreaturesBoost { get; set; }
        public CharacterBaseCharacteristic Reflect { get; set; }
        public CharacterBaseCharacteristic CriticalHit { get; set; }

        [CustomVar]
        public ushort CriticalHitWeapon { get; set; }

        public CharacterBaseCharacteristic CriticalMiss { get; set; }
        public CharacterBaseCharacteristic HealBonus { get; set; }
        public CharacterBaseCharacteristic AllDamagesBonus { get; set; }
        public CharacterBaseCharacteristic WeaponDamagesBonusPercent { get; set; }
        public CharacterBaseCharacteristic DamagesBonusPercent { get; set; }
        public CharacterBaseCharacteristic TrapBonus { get; set; }
        public CharacterBaseCharacteristic TrapBonusPercent { get; set; }
        public CharacterBaseCharacteristic GlyphBonusPercent { get; set; }
        public CharacterBaseCharacteristic RuneBonusPercent { get; set; }
        public CharacterBaseCharacteristic PermanentDamagePercent { get; set; }
        public CharacterBaseCharacteristic TackleBlock { get; set; }
        public CharacterBaseCharacteristic TackleEvade { get; set; }
        public CharacterBaseCharacteristic PAAttack { get; set; }
        public CharacterBaseCharacteristic PMAttack { get; set; }
        public CharacterBaseCharacteristic PushDamageBonus { get; set; }
        public CharacterBaseCharacteristic CriticalDamageBonus { get; set; }
        public CharacterBaseCharacteristic NeutralDamageBonus { get; set; }
        public CharacterBaseCharacteristic EarthDamageBonus { get; set; }
        public CharacterBaseCharacteristic WaterDamageBonus { get; set; }
        public CharacterBaseCharacteristic AirDamageBonus { get; set; }
        public CharacterBaseCharacteristic FireDamageBonus { get; set; }
        public CharacterBaseCharacteristic DodgePALostProbability { get; set; }
        public CharacterBaseCharacteristic DodgePMLostProbability { get; set; }
        public CharacterBaseCharacteristic NeutralElementResistPercent { get; set; }
        public CharacterBaseCharacteristic EarthElementResistPercent { get; set; }
        public CharacterBaseCharacteristic WaterElementResistPercent { get; set; }
        public CharacterBaseCharacteristic AirElementResistPercent { get; set; }
        public CharacterBaseCharacteristic FireElementResistPercent { get; set; }
        public CharacterBaseCharacteristic NeutralElementReduction { get; set; }
        public CharacterBaseCharacteristic EarthElementReduction { get; set; }
        public CharacterBaseCharacteristic WaterElementReduction { get; set; }
        public CharacterBaseCharacteristic AirElementReduction { get; set; }
        public CharacterBaseCharacteristic FireElementReduction { get; set; }
        public CharacterBaseCharacteristic PushDamageReduction { get; set; }
        public CharacterBaseCharacteristic CriticalDamageReduction { get; set; }
        public CharacterBaseCharacteristic PvpNeutralElementResistPercent { get; set; }
        public CharacterBaseCharacteristic PvpEarthElementResistPercent { get; set; }
        public CharacterBaseCharacteristic PvpWaterElementResistPercent { get; set; }
        public CharacterBaseCharacteristic PvpAirElementResistPercent { get; set; }
        public CharacterBaseCharacteristic PvpFireElementResistPercent { get; set; }
        public CharacterBaseCharacteristic PvpNeutralElementReduction { get; set; }
        public CharacterBaseCharacteristic PvpEarthElementReduction { get; set; }
        public CharacterBaseCharacteristic PvpWaterElementReduction { get; set; }
        public CharacterBaseCharacteristic PvpAirElementReduction { get; set; }
        public CharacterBaseCharacteristic PvpFireElementReduction { get; set; }
        public CharacterBaseCharacteristic MeleeDamageDonePercent { get; set; }
        public CharacterBaseCharacteristic MeleeDamageReceivedPercent { get; set; }
        public CharacterBaseCharacteristic RangedDamageDonePercent { get; set; }
        public CharacterBaseCharacteristic RangedDamageReceivedPercent { get; set; }
        public CharacterBaseCharacteristic WeaponDamageDonePercent { get; set; }
        public CharacterBaseCharacteristic WeaponDamageReceivedPercent { get; set; }
        public CharacterBaseCharacteristic SpellDamageDonePercent { get; set; }
        public CharacterBaseCharacteristic SpellDamageReceivedPercent { get; set; }
        public uint ProbationTime { get; set; }
    }
}