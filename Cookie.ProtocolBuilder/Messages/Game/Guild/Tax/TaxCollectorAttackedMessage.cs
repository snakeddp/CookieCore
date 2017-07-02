using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Guild.Tax
{
    [NetworkMessage(5918)]
    public class TaxCollectorAttackedMessage
    {
        [CustomVar]
        public ushort FirstNameId { get; set; }

        [CustomVar]
        public ushort LastNameId { get; set; }

        public short WorldX { get; set; }
        public short WorldY { get; set; }
        public int MapId { get; set; }

        [CustomVar]
        public ushort SubAreaId { get; set; }

        public BasicGuildInformations Guild { get; set; }
    }
}