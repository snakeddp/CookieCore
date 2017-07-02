using System;

namespace Cookie.IO.Types
{
    public class CustomInt64 : Binary64
    {
        public CustomInt64()
        {
        }

        public CustomInt64(uint low = 0, uint high = 0)
            : base(low, high)
        {
        }

        public uint High
        {
            get => InternalHigh;
            set => InternalHigh = value;
        }

        public static CustomInt64 FromNumber(long n)
        {
            return new CustomInt64((uint) n, (uint) Math.Floor(n / 4.294967296E9));
        }

        public long ToNumber()
        {
            return (long) (High * 4.294967296E9 + Low);
        }
    }
}