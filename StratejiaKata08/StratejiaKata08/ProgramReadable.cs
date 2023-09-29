namespace StratejiaKata08
{
    public class ProgramReadable
    {
        static readonly string textFile = "wordlist.txt";
        static readonly int _MinLength = 1;
        static readonly int _MaxLength = 5;

        /// <summary>
        /// For loop process
        /// </summary>
        /// <param name="args"></param>
        public static void RunForLoop(string[] args)
        {
            string[] linesFiltered = Array.FindAll(File.ReadAllLines(textFile), x => x.Length >= _MinLength && x.Length <= _MaxLength);
            //List<string> linesFiltered = File.ReadAllLines(textFile).AsEnumerable().Where(a => a.Length >= _MinLength && a.Length < _MaxLength).ToList();
            ForLoop(linesFiltered);
        }

        /// <summary>
        /// Le process est plus long de 2-3 minutes
        /// </summary>
        /// <param name="args"></param>
        public static void RunForEachLoop(string[] args)
        {
            string[] linesFiltered = Array.FindAll(File.ReadAllLines(textFile), x => x.Length >= _MinLength && x.Length <= _MaxLength);
            //List<string> linesFiltered = File.ReadAllLines(textFile).AsEnumerable().Where(a => a.Length >= _MinLength && a.Length < _MaxLength).ToList();
            var lines = ForEachLoop(linesFiltered);
            foreach (var line in lines)
            {
                Utils.WriteLine(line);
            }
            Utils.CountLines(lines.Count());

        }

        

        /// <summary>
        /// For loop process with writing each line combine and total count for an Array
        /// La gestion est moins lourde via un Array
        /// </summary>
        /// <param name="linesFiltered"></param>
        public static void ForLoop(string[] linesFiltered)
        {
            int count = 0;
            for (int i = 0; i < linesFiltered.Length; i++)
            {
                for (int j = 0; j < linesFiltered.Length; j++)
                {
                    if (linesFiltered[i].Length + linesFiltered[j].Length == 6)
                    {
                        count++;
                        Utils.WriteLine(linesFiltered, i, j);
                    }

                }
            }
            Utils.CountLines(count);
        }

        /// <summary>
        /// For loop process with writing each line combine and total count for a List
        /// La gestion est plus lourde via une List
        /// </summary>
        /// <param name="linesFiltered"></param>
        public static void ForLoop(List<string> linesFiltered)
        {
            int count = 0;
            for (int i = 0; i < linesFiltered.Count; i++)
            {
                for (int j = 0; j < linesFiltered.Count; j++)
                {
                    if (linesFiltered[i].Length + linesFiltered[j].Length == 6)
                    {
                        count++;
                        Utils.WriteLine(linesFiltered, i, j);
                    }

                }
            }
            Utils.CountLines(count);
        }

        public static IEnumerable<(string, string)> ForEachLoop(string[] linesFiltered)
        {
            foreach (string line1 in linesFiltered)
            {
                foreach (string line2 in linesFiltered)
                {
                    if (line1.Length + line2.Length == 6)
                    {
                        yield return (line1, line2);
                    }
                }
            }
        }

        public static IEnumerable<(string, string)> ForEachLoop(List<string> linesFiltered)
        {
            foreach (string line1 in linesFiltered)
            {
                foreach (string line2 in linesFiltered)
                {
                    if (line1.Length + line2.Length == 6)
                    {
                        yield return (line1, line2);
                    }
                }
            }
        }
        
        
    }
}
