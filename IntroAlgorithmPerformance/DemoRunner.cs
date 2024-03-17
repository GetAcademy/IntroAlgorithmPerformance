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
            Console.Write($"Lager {type.Name} - størrelse: {size} ");
            var instance = Activator.CreateInstance(type, size);
            stopwatch.Stop();
            var spent = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Brukte {spent:n0} millisekunder");
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
            var spent = stopwatch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine($"Brukte {spent} sekunder");
        }

        protected abstract void Run();
    }
}
