using System.Diagnostics;

namespace IntroAlgorithmPerformance
{
    internal abstract class DemoRunner
    {
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
            var stopwatch = new Stopwatch();
            Console.WriteLine($"Start N={Value}");
            stopwatch.Start();
            Run();
            stopwatch.Stop();
            var spent = stopwatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine($"Brukte {spent:F} sekunder");
        }

        protected abstract void Run();
    }
}
