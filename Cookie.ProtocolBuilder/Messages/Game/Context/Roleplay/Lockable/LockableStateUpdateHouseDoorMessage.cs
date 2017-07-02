namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    [NetworkMessage(5668)]
    public class LockableStateUpdateHouseDoorMessage : LockableStateUpdateAbstractMessage
    {
        [CustomVar]
        public uint HouseId { get; set; }

        public uint InstanceId { get; set; }

        [RegularBool]
        public bool SecondHand { get; set; }
    }
}