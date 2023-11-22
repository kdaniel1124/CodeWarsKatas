using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class GravityFlip
    {
        public int[] Flip(char dir, int[] arr)
        {
            List<int> stacks = arr.ToList();
            stacks.Sort();

            if (dir == 'L')
            {
                stacks.Reverse();
            }

            int[] sortedStacks = stacks.ToArray();

            return sortedStacks;
        }
    }
}
