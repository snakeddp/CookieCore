namespace Cookie.Protocol.Messages.Game.Context.Mount
{
    [NetworkMessage(6697)]
    public class MountHarnessColorsUpdateRequestMessage
    {
        [RegularBool]
        public bool UseHarnessColors { get; set; }
    }
}