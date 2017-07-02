using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Types.Game.Dare
{
    [NetworkType(504)]
    public class DareVersatileInformations
    {
        public double DareId { get; set; }
        public uint CountEntrants { get; set; }
        public uint CountWinners { get; set; }
    }
}