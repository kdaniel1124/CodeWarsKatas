using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class DirectionsReduction
    {
        public string[] DirReduc(string[] arr)
        {
            List<string> result = arr.ToList();
            int northCount = 0;
            int southCount = 0;
            int eastCount = 0;
            int westCount = 0;

            foreach(string dir in arr)
            {
                switch (dir)
                {
                    case "NORTH": northCount++;
                        break;
                    case "SOUTH": southCount++;
                        break;
                    case "EAST": eastCount++;
                        break;
                    case "WEST": westCount++;
                        break;
                    default:
                        break;
                }

                if(northCount > 1 && southCount > 1)
                {
                    result.Remove("NORTH");
                    result.Remove("SOUTH");
                    southCount--;
                    northCount--;
                }

                if(eastCount > 1 && westCount > 1)
                {
                    result.Remove("EAST");
                    result.Remove("WEST");
                    eastCount--;
                    westCount--;
                }
            }
            return result.ToArray();
        }
    }
}
