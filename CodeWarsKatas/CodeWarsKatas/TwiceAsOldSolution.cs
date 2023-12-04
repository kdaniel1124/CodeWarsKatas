using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class TwiceAsOldSolution
    {
        // https://www.codewars.com/kata/5b853229cfde412a470000d0/train/csharp
        public int TwiceAsOld(int dadYears, int sonYears)
        {
            int dadAge = dadYears - sonYears;
            int sonAge = 0;

            for (int i = 0; i < 100; i++)
            {
                if( sonAge * 2 == dadAge)
                {
                    break;
                }
                else
                {
                    sonAge++;
                    dadAge++;
                }
            }
            return sonAge;
        }
    }
}
