using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas
{
    // https://www.codewars.com/kata/525f50e3b73515a6db000b83
    public class PhoneNumbers
    {
        public string CreatePhoneNumber(int[] nums)
        {
            return $"({nums[0]}{nums[1]}{nums[2]}) {nums[3]}{nums[4]}{nums[5]}-{nums[6]}{nums[7]}{nums[8]}{nums[9]}";
        }
    }
}
