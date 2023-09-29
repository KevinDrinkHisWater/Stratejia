using System.Diagnostics;

namespace StratejiaKata08
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Stopwatch sw = new Stopwatch();

                Console.WriteLine($"Running {nameof(ProgramReadable)}");
                sw.Start();
                ProgramReadable.RunForLoop(args);
                var readableRunningTime = sw.Elapsed;

                Console.WriteLine($"Running {nameof(ProgramFast)}");
                sw.Restart();
                ProgramFast.RunForLoop(args);
                var fastRunningTime = sw.Elapsed;

                Console.WriteLine($"Readable was running for: {readableRunningTime}");
                Console.WriteLine($"Fast was running for: {fastRunningTime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
