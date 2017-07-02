namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(5975)]
    public class MountInformationInPaddockRequestMessage
    {
        [CustomVar]
        public int MapRideId { get; set; }
    }
}