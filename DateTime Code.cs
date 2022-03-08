using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {   // 10/19/2017 8:12:35AM

            string dateString;
                
            Console.WriteLine("Enter date (mounth/day/year h:m:s AM/PM): ");
            dateString = Convert.ToString(Console.ReadLine()); // месяц/день/год ч:м:с АМ/РМ
            DateTime MyDate = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("This day: " + MyDate);
            Console.WriteLine("Day of Week: "+ MyDate.DayOfWeek);

            var greg = new GregorianCalendar();
            
            if (greg.GetWeekOfYear(MyDate, CalendarWeekRule.FirstDay, DayOfWeek.Thursday) / 2 == 0)
                 Console.WriteLine("Week even"); //чётная
            else Console.WriteLine("Odd week"); //нечётная

            var numWeekend = 6; // 0=sunday
            var numToday = 4;
            var dayForWeekend = ((DayOfWeek)numWeekend - ((DayOfWeek)numToday));
            Console.WriteLine("Дней до выходных (до воскресенья): " + dayForWeekend);


            Console.ReadKey();
        }
    }
}
