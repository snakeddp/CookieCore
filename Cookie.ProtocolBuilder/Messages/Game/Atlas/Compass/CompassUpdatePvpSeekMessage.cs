namespace Cookie.Protocol.Messages.Game.Atlas.Compass
{
    [NetworkMessage(6013)]
    public class CompassUpdatePvpSeekMessage : CompassUpdateMessage
    {
        [CustomVar]
        public long MemberId { get; set; }

        public string MemberName { get; set; }
    }
}