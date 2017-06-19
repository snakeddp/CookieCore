
using Cookie.Core.Attributes.Class;

namespace Cookie.Protocol.Messages.Game.Almanach
{
    [NetworkMessage(6341)]
    public class AlmanachCalendarDateMessage
    {
        public int Date { get; set; }
    }
}
