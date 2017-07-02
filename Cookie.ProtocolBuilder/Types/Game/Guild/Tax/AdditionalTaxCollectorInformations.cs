namespace Cookie.Protocol.Types.Game.Guild.Tax
{
    [NetworkType(165)]
    public class AdditionalTaxCollectorInformations
    {
        public string CollectorCallerName { get; set; }
        public uint Date { get; set; }
    }
}