using System.Diagnostics;

namespace IntroAlgorithmPerformance
{
    internal abstract class DemoRunner
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();
        public int Value { get; }

        protected static void RunDemoes(IEnumerable<DemoRunner> demos)
        {
            foreach (var demo in demos)
            {
                demo.RunAndMeasure(); 
            }
        }

        protected DemoRunner(int value)
        {
            Value = value;
        }

        public void RunAndMeasure()
        {
            Console.WriteLine($"Start N={Value}");
            Stopwatch.Start();
            Run();
            Stopwatch.Stop();
            var spent = Stopwatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine($"Brukte {spent:F} sekunder");
        }

        protected abstract void Run();
    }
}
