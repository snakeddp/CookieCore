namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(493)]
    public class TaxCollectorMovement
    {
        public sbyte MovementType { get; set; }
        public TaxCollectorBasicInformations BasicInfos { get; set; }

        [CustomVar]
        public long PlayerId { get; set; }

        public string PlayerName { get; set; }
    }
}