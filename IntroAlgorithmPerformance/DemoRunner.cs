using System.Diagnostics;

namespace IntroAlgorithmPerformance
{
    internal class DemoRunner
    {
        public static void Run(Action<int> action, params int[] values)
        {
            var stopwatch = new Stopwatch();

            foreach (var value in values)
            {
                Console.WriteLine($"Start N={value}");
                stopwatch.Start();
                action(value);
                stopwatch.Stop();
                var spent = stopwatch.ElapsedMilliseconds / 1000.0;
                Console.WriteLine($"Brukte {spent:F} sekunder");
            }
        }
    }
}
