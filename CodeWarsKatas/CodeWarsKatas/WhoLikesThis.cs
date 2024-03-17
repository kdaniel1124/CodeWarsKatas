using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class WhoLikesThis
    {
        public string Likes(string[] names)
        {
            string response = "";

            if (names.Length == 0)
            {
                response = "no one likes this";
            }
            else if (names.Length == 1)
            {
                response = $"{names[0]} likes this";
            }
            else if (names.Length == 2)
            {
                response = $"{names[0]} and {names[1]} like this";
            }
            else if (names.Length == 3)
            {
                response = $"{names[0]}, {names[1]} and {names[2]} like this";
            }
            else
            {
                response = $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
            }
            return response;
        }
    }
}
