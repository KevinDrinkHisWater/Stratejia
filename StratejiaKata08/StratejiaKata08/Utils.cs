namespace StratejiaKata08
{
    public class Utils
    {
        public static void WriteLine(string[] linesFiltered, int i, int j)
        {
            Console.WriteLine($"{linesFiltered.ElementAt(i)} + {linesFiltered.ElementAt(j)} => {linesFiltered.ElementAt(i) + linesFiltered.ElementAt(j)}");
        }

        public static void WriteLine(List<string> linesFiltered, int i, int j)
        {
            Console.WriteLine($"{linesFiltered.ElementAt(i)} + {linesFiltered.ElementAt(j)} => {linesFiltered.ElementAt(i) + linesFiltered.ElementAt(j)}");
        }

        public static void WriteLine((string, string) line)
        {
            Console.WriteLine($"{line.Item1} + {line.Item2} => {line.Item1 + line.Item2}");
        }

        public static void CountLines(int count)
        {
            Console.WriteLine($"sums found with readable: {count}");
        }
    }
}