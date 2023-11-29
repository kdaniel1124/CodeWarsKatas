using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class SpoonerizeMe
    {
        public string Spoonerize(string str)
        {
            char first = str[0];
            string result = "";

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ')
                {
                    result = str[i] + result + first;
                }
                else
                {
                    result += str[i];
                }
            }
            return result;
        }
    }
}
