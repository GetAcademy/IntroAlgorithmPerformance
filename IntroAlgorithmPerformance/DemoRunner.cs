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
            var stopwatch = Stopwatch.StartNew();
            Console.Write($"Start N={Value:n0}".PadRight(30));
            Run();
            stopwatch.Stop();
            var spent = stopwatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine($"Brukte {spent} sekunder");
        }

        protected abstract void Run();
    }
}
