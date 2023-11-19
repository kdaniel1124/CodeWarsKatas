using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class CountingDuplicates
    {
        public int DuplicateCount(string str)
        {
            Dictionary<string, int> dupeBook = new Dictionary<string, int>();
            int dupeCount = 0;

            foreach(char thing in str)
            {
                if (dupeBook.ContainsKey(thing.ToString()))
                {
                    dupeBook[thing.ToString()] ++;
                }
                else
                {
                    dupeBook[thing.ToString()] = 1;
                }
            }

            foreach(KeyValuePair<string, int> kvp in dupeBook)
            {
                if (kvp.Value > 1)
                {
                    dupeCount++;
                }
            }

            return dupeCount;
        }
    }
}
