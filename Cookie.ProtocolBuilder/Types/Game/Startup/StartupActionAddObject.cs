namespace Cookie.Protocol.Types.Game.Startup
{
    [NetworkType(52)]
    public class StartupActionAddObject
    {
        public uint Uid { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string DescUrl { get; set; }
        public string PictureUrl { get; set; }
    }
}