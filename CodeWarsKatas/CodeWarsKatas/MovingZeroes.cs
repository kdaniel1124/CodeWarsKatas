using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class MovingZeroes
    {
        public int[] MoveZeroes(int[] nums)
        {
            List<int> result = nums.ToList();

            foreach(int num in nums)
            {
                if(num == 0)
                {
                    result.Remove(0);
                    result.Add(0);
                }
            }
            return result.ToArray();
        }
    }
}
