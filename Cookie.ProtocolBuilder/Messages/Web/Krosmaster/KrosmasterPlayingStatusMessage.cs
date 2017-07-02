namespace Cookie.Protocol.Messages.Web.Krosmaster
{
    [NetworkMessage(6347)]
    public class KrosmasterPlayingStatusMessage
    {
        [RegularBool]
        public bool Playing { get; set; }
    }
}