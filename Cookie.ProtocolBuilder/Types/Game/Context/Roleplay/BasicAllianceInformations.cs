namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(419)]
    public class BasicAllianceInformations : AbstractSocialGroupInfos
    {
        [CustomVar]
        public uint AllianceId { get; set; }

        public string AllianceTag { get; set; }
    }
}