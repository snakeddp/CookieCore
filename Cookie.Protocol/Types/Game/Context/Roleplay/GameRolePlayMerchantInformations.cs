
using Cookie.Core.Attributes.Class;
using Cookie.Protocol.Types.Game.Context.Roleplay;

namespace Cookie.Protocol.Types.Game.Context.Roleplay
{
    [NetworkType(129)]
    public class GameRolePlayMerchantInformations : GameRolePlayNamedActorInformations
    {
        public sbyte SellType { get; set; }
    }
}
