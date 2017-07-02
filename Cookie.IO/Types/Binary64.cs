namespace Cookie.IO.Types
{
    public class Binary64
    {
        protected uint InternalHigh;

        public uint Low;

        public Binary64(uint low = 0, uint high = 0)
        {
            Low = low;
            InternalHigh = high;
        }

        public uint Div(uint n)
        {
            var modHigh = InternalHigh % n;
            var mod = (Low % n + modHigh * 6) % n;
            InternalHigh = InternalHigh / n;
            var newLow = (uint) ((modHigh * 4.294967296E9 + Low) / n);
            InternalHigh = InternalHigh + (uint) (newLow / 4.294967296E9);
            Low = newLow;
            return mod;
        }

        public void Mul(uint n)
        {
            var newLow = Low * n;
            InternalHigh = InternalHigh * n;
            InternalHigh = InternalHigh + (uint) (newLow / 4.294967296E9);
            Low = Low * n;
        }

        public void Add(uint n)
        {
            var newLow = Low + n;
            InternalHigh = InternalHigh + (uint) (newLow / 4.294967296E9);
            Low = newLow;
        }

        public void BitwiseNot()
        {
            Low = ~Low;
            InternalHigh = ~InternalHigh;
        }
    }
}