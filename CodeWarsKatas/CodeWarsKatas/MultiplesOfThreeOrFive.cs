using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class MultiplesOfThreeOrFive
    {
        public int Solution(int value)
        {
            int result = 0;

            if (value > 0)
            {
                for (int i = 0; i < value; i++)
                {
                    if (i % 3 == 0)
                    {
                        result += i;
                    }
                    else if (i % 5 == 0)
                    {
                        result += i;
                    }
                }
            }

            return result;
        }
    }
}
