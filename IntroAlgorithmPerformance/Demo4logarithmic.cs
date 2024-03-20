namespace IntroAlgorithmPerformance
{
    internal class Demo4logarithmic : DemoRunner
    {
        public static void Start()
        {
            var nValues = new[] { 10000000};
            var demos = nValues.Select(Create<Demo4logarithmic>);
            RunDemoes(demos);
        }

        protected override void Run()
        {
            var found5 = _randomIntList.Contains(5);
        }

        private readonly RandomSortedIntList _randomIntList;

        public Demo4logarithmic(int size) : base(size)
        {
            _randomIntList = new RandomSortedIntList(size);
        }
    }
}
