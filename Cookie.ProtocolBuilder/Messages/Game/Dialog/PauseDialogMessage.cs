namespace Cookie.Protocol.Messages.Game.Dialog
{
    [NetworkMessage(6012)]
    public class PauseDialogMessage
    {
        public sbyte DialogType { get; set; }
    }
}