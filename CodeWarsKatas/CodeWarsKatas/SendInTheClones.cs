using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class SendInTheClones
    {
        public int[] CloneWars(int kataPerDay)
        {
            int cloneCount = 1;
            int kataCompleted = 0;

            for (int i = kataPerDay; i > 0; i--)
            {
                kataCompleted += i * cloneCount;
                cloneCount *= 2;
            }

            int[] result = new int[] { cloneCount, kataCompleted };

            return result;
        }
    }
}
