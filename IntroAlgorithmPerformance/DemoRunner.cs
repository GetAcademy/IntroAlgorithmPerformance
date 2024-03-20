using System.Diagnostics;

namespace IntroAlgorithmPerformance
{
    internal abstract class DemoRunner
    {
        public int Size { get; }

        protected static void RunDemoes(IEnumerable<DemoRunner> demos)
        {
            foreach (var demo in demos.ToArray())
            {
                demo.RunAndMeasure(); 
            }
        }

        protected static T Create<T>(int size)
        {
            var stopwatch = Stopwatch.StartNew();
            var type = typeof(T);
            Console.Write($"Lager {type.Name} ({size:n0}) ");
            var instance = Activator.CreateInstance(type, size);
            stopwatch.Stop();
            var seconds = stopwatch.ElapsedMilliseconds/ 1000;
            Console.WriteLine($"Brukte {seconds:n0} sekunder");
            return (T)instance;
        }

        protected DemoRunner(int size)
        {
            Size = size;
        }

        public void RunAndMeasure()
        {
            var stopwatch = Stopwatch.StartNew();
            Console.Write($"Start N={Size:n0}".PadRight(30));
            Run();
            stopwatch.Stop();
            var spent = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Brukte {spent:n0} millisekunder");
        }

        protected abstract void Run();
    }
}
