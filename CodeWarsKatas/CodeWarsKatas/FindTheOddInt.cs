using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class FindTheOddInt
    {
        public int FindOdd(int[] nums)
        {
            Dictionary<int, int> numCounter = new Dictionary<int, int>();
            int result = 0;

            foreach (int num in nums)
            {
                if (!numCounter.ContainsKey(num))
                {
                    numCounter[num] = 1;
                }
                else
                {
                    numCounter[num]++;
                }
            }

            foreach (KeyValuePair<int, int> kvp in numCounter)
            {
                if (kvp.Value % 2 == 1)
                {
                    result = kvp.Key;
                    break;
                }
            }

            return result;
        }
    }
}
