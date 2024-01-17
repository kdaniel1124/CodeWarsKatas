using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    public class TicketPrice
    {
        public decimal GetPrice(List<int> ages, bool isWeekend)
        {
            decimal price = 0.00m;

            foreach(int age in ages)
            {
                if(age <= 12)
                {
                    price += 5;
                }
                else if (age >= 13 && age <= 17)
                {
                    price += 8;
                }
                else if (age >= 18 && age <= 64)
                {
                    if (isWeekend)
                    {
                        price += (12 * 1.05m);
                    }
                    else
                    {
                        price += 12;
                    }
                }
                else
                {
                    if (isWeekend)
                    {
                        price += (10 * 1.05m);
                    }
                    else
                    {
                        price += 10;
                    }
                }
            }

            if(ages.Count() >= 5)
            {
                return price * 0.90m;
            }
            else
            {
                return price;
            }
        }
    }
}
