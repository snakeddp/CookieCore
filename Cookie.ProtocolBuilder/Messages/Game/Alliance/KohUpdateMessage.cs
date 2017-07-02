using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Messages.Game.Alliance
{
    [NetworkMessage(6439)]
    public class KohUpdateMessage
    {
        [CustomVar]
        [LengthType(typeof(short))]
        public ushort[] AllianceNbMembers { get; set; }

        [CustomVar]
        [LengthType(typeof(short))]
        public uint[] AllianceRoundWeigth { get; set; }

        [LengthType(typeof(short), true)]
        public sbyte[] AllianceMatchScore { get; set; }

        public BasicAllianceInformations AllianceMapWinner { get; set; }

        [CustomVar]
        public uint AllianceMapWinnerScore { get; set; }

        [CustomVar]
        public uint AllianceMapMyAllianceScore { get; set; }

        public double NextTickTime { get; set; }
    }
}