namespace Cookie.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    [NetworkMessage(6639)]
    public class ChangeThemeRequestMessage
    {
        public byte Theme { get; set; }
    }
}