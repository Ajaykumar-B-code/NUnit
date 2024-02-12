using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drivingAgeChecker
{
    public class driveAgeChecker
    {
        public string AgeChecker(int  age)
        {
            if (age >= 18)
            {
                return "Allowed";
            }
            else
            {
                return "Not Allowed";
            }
        }
    }
}
