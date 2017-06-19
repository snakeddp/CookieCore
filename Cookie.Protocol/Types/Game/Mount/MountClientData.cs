
using Cookie.Core.Attributes.Class;
using Cookie.Core.Attributes.Property;
using Cookie.Protocol.Types.Game.Data.Items.Effects;

namespace Cookie.Protocol.Types.Game.Mount
{
    [NetworkType(178)]
    public class MountClientData
    {
        public double Id { get; set; }
        [CustomVar]
        public uint Model { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] Ancestor { get; set; }
        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] Behaviors { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public uint OwnerId { get; set; }
        [CustomVar]
        public long Experience { get; set; }
        [CustomVar]
        public long ExperienceForLevel { get; set; }
        public double ExperienceForNextLevel { get; set; }
        public sbyte Level { get; set; }
        public bool IsRideable { get; set; }
        [CustomVar]
        public uint MaxPods { get; set; }
        public bool IsWild { get; set; }
        [CustomVar]
        public uint Stamina { get; set; }
        [CustomVar]
        public uint StaminaMax { get; set; }
        [CustomVar]
        public uint Maturity { get; set; }
        [CustomVar]
        public uint MaturityForAdult { get; set; }
        [CustomVar]
        public uint Energy { get; set; }
        [CustomVar]
        public uint EnergyMax { get; set; }
        public int Serenity { get; set; }
        public int AggressivityMax { get; set; }
        [CustomVar]
        public uint SerenityMax { get; set; }
        [CustomVar]
        public uint Love { get; set; }
        [CustomVar]
        public uint LoveMax { get; set; }
        public int FecondationTime { get; set; }
        public bool IsFecondationReady { get; set; }
        public uint BoostLimiter { get; set; }
        public double BoostMax { get; set; }
        public int ReproductionCount { get; set; }
        [CustomVar]
        public uint ReproductionCountMax { get; set; }
        [CustomVar]
        public ushort HarnessGID { get; set; }
        public bool UseHarnessColors { get; set; }
    }
}
