using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    // https://www.codewars.com/kata/55ecd718f46fba02e5000029/csharp
    public class WhatIsBetween
    {
        public int[] Between(int a, int b)
        {
            List<int> result = new List<int>();

            for (int i = a; i <= b; i++)
            {
                result.Add(i);
            }
            return result.ToArray();
        }
    }
}
