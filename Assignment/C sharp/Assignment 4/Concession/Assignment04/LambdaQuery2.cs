using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    class LambdaQuery2
    {

        static void Main()
        {
            List<string> Word = new List<string> { "atom", "bloom", "fire", "aam", "amsterdam" };

            var wd = Word.Where(words => words.StartsWith("a", StringComparison.OrdinalIgnoreCase)
            && words.EndsWith("m", StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine("words start with 'a' n end with 'm' : ");

            foreach (var words in wd)
            {
                Console.WriteLine(words);

            }

            Console.Read();

        }
        }
}

