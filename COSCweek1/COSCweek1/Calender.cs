using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSCweek1
{
    class Calender
    {
        //This method will determine the number of days in a week or month.

        public void dayCalculator()
        { //Here are my constants...

            const int Months = 12;
            const int Weeks = 52;
            const int Days = 365;


            const int daysPerWeek = (int)Days / (int)Weeks;
            const int daysPerMonth = (int)Days / (int)Months;

            //These varibles will tell the user the number of days.

            var daysInMonth = daysPerMonth;
            var daysInWeek = daysPerWeek;
            Console.WriteLine("The number of days in a month is", daysInMonth);

            Console.WriteLine("The number of days in a week is", daysInWeek);
            Console.ReadKey();

        }


    }
}
