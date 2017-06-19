using System;

namespace Cookie.Protocol.Enums
{
    [Flags]
    public enum SubEntityBindingPointCategoryEnum
    {
        HookPointCategoryUnused = 0,
        HookPointCategoryPet = 1,
        HookPointCategoryMountDriver = 2,
        HookPointCategoryLiftedEntity = 3,
        HookPointCategoryBaseBackground = 4,
        HookPointCategoryMerchantBag = 5,
        HookPointCategoryBaseForeground = 6,
        HookPointCategoryPetFollower = 7,
        HookPointCategoryUnderwaterBubbles = 8
    }
}
