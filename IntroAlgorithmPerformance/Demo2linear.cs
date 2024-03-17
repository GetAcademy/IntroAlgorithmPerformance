namespace IntroAlgorithmPerformance
{
    internal class Demo2linear : DemoRunner
    {
        public static void Start()
        {
            var nValues = new[] { 10000000, 100000000, 1000000000 };
            var demos = nValues.Select(Create<Demo2linear>);
            RunDemoes(demos);
        }

        protected override void Run()
        {
            var found5 = _randomIntList.Contains(5);
        }

        private readonly RandomIntList _randomIntList;

        public Demo2linear(int size) : base(size)
        {
            _randomIntList = new RandomIntList(size);
        }
    }
}
