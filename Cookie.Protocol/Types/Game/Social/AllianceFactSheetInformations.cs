using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Social
{
    [NetworkType(421)]
    public class AllianceFactSheetInformations : AllianceInformations
    {
        public uint CreationDate { get; set; }
    }
}