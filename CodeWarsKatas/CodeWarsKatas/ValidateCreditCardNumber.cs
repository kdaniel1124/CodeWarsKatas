using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class ValidateCreditCardNumber
    {
        public bool Validate(string n)
        {
            string noSpaces = "";

            foreach (char letter in n)
            {
                if (letter != ' ')
                {
                    noSpaces += letter;
                }
            }

            int position = noSpaces.Length % 2;

            int sum = 0;

            for (int i = 0; i < noSpaces.Length; i++)
            {
                int num = Convert.ToInt32(new string (noSpaces[i], 1));

                if (i % 2 == position)
                {
                    num *= 2;
                }

                while (num >= 10)
                {
                    num -= 9;
                }

                sum += num;
            }

            return (sum % 10 == 0);
        }
    }
}
