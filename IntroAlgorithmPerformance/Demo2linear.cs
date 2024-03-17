namespace IntroAlgorithmPerformance
{
    internal class Demo2linear : DemoRunner
    {
        public static void Start()
        {
            var nValues = new[] { 10000000, 100000000, 1000000000 };
            var demos = nValues.Select(n => new Demo2linear(n));
            RunDemoes(demos);
        }

        protected override void Run()
        {
            var found5 = false;
            foreach (var number in _randomIntList)
            {
                if (number == 5) found5 = true;
            }
        }

        private readonly RandomIntList _randomIntList;

        public Demo2linear(int size) : base(size)
        {
            _randomIntList = new RandomIntList(size);
        }
    }
}
