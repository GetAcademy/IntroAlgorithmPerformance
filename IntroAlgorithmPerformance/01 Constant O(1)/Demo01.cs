namespace IntroAlgorithmPerformance._01_Constant_O_1_
{
    internal class Demo01
    {
        public static void Run()
        {
            var nValues = new[] {100, 100000, 1000000};
            var demoes = nValues.Select(n => new Demo01(n));
        }

        private RandomIntList _randomIntList;

        public Demo01(int size)
        {
            _randomIntList = new RandomIntList(size);
        }
    }
}
