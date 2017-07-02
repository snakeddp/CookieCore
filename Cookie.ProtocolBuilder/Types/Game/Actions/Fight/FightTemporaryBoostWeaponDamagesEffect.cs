namespace Cookie.Protocol.Types.Game.Actions.Fight
{
    [NetworkType(211)]
    public class FightTemporaryBoostWeaponDamagesEffect : FightTemporaryBoostEffect
    {
        public short WeaponTypeId { get; set; }
    }
}