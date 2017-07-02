namespace Cookie.Protocol.Messages.Game.Friend
{
    [NetworkMessage(6265)]
    public class SpouseStatusMessage
    {
        [RegularBool]
        public bool HasSpouse { get; set; }
    }
}