namespace IntroAlgorithmPerformance._01_Constant_O_1_
{
    internal class Demo01 : DemoRunner
    {

        public static void Start()
        {
            var nValues = new[] {1000, 10000, 100000};
            var demos = nValues.Select(n => new Demo01(n));
            RunDemoes(demos);
        }

        protected override void Run()
        {
            _randomIntList[_randomIntList.Count / 2]++;
        }

        private readonly RandomIntList _randomIntList;

        public Demo01(int size) : base(size) 
        {
            _randomIntList = new RandomIntList(size);
        }
    }
}
