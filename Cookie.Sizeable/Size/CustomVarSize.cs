namespace Cookie.Sizeable.Size
{
    public static class CustomVarSize
    {
        private const int FirstLv = 16384;
        private const int SecondLv = 2097152;
        private const int ThirdLv = 268435456;
        private const long FourthLv = 34359738368;
        private const long FifthLv = 4398046511104;
        private const long SixthLv = 562949953421312;
        private const long SeventhLv = 72057594037927936;

        public static int GetCustomShortSize(short value)
        {
            var size = 0;

            if (value >= 0 && value <= sbyte.MaxValue)
                size = 1;
            else if (value > sbyte.MaxValue && value < FirstLv)
                size = 2;
            else if (value >= FirstLv)
                size = 3;

            return size;
        }

        public static int GetCustomIntSize(int value)
        {
            var size = 0;

            if (value >= 0 && value <= sbyte.MaxValue)
                size = 1;
            else if (value > sbyte.MaxValue && value < FirstLv)
                size = 2;
            else if (value > FirstLv && value < SecondLv)
                size = 3;
            else if (value > SecondLv && value < ThirdLv)
                size = 4;
            else if (value >= ThirdLv)
                size = 5;

            return size;
        }

        public static int GetCustomLongSize(long value)
        {
            var size = 0;

            if (value >= 0 && value <= sbyte.MaxValue)
                size = 1;
            else if (value > sbyte.MaxValue && value < FirstLv)
                size = 2;
            else if (value > FirstLv && value < SecondLv)
                size = 3;
            else if (value > SecondLv && value < ThirdLv)
                size = 4;
            else if (value > ThirdLv && value < FourthLv)
                size = 5;
            else if (value > FourthLv && value < FifthLv)
                size = 6;
            else if (value > FifthLv && value < SixthLv)
                size = 7;
            else if (value > SixthLv && value < SeventhLv)
                size = 8;
            else if (value >= SeventhLv)
                size = 9;

            return size;
        }
    }
}