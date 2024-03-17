namespace IntroAlgorithmPerformance
{
    internal class Demo1constant : DemoRunner
    {

        public static void Start()
        {
            var nValues = new[] { 1000, 10000, 100000 };
            var demos = nValues.Select(n => new Demo1constant(n));
            RunDemoes(demos);
        }

        protected override void Run()
        {
            _randomIntList[_randomIntList.Count / 2]++;
        }

        private readonly RandomIntList _randomIntList;

        public Demo1constant(int size) : base(size)
        {
            _randomIntList = new RandomIntList(size);
        }
    }
}
