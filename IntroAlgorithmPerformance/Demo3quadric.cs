namespace IntroAlgorithmPerformance
{
    internal class Demo3quadric : DemoRunner
    {
        public static void Start()
        {
            var nValues = new[] { 100, 1000, 10000};
            var demos = nValues.Select(Create<Demo3quadric>);
            RunDemoes(demos);
        }

        protected override void Run()
        {
            var pairs = new List<string>(Size*Size);
            for (var a = 1; a <= Size; a++)
            {
                for (var b = 1; b <= Size; b++)
                {
                    pairs.Add($"{a} x {b}");
                }
            }
        }

        public Demo3quadric(int size) : base(size)
        {
        }
    }
}
