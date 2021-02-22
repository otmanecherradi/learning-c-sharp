using System;

namespace Seance0222
{
    class Program
    {
        static void Main(string[] args)
        {
            // date time

            // current date time
            DateTime now = DateTime.Now;
            Console.WriteLine("current date is :" + now);

            Console.WriteLine("\n---------------------------------------------------\n");

            // istantiate a new date object
            DateTime date = new DateTime(2020, 3, 16, 8, 0, 0);
            Console.WriteLine("the date of lockdown was {0}", date.Date);
            Console.WriteLine("the date of lockdown was {0}", date.ToString("G"));

            Console.WriteLine("\n---------------------------------------------------\n");

            // compare dates
            Console.WriteLine("today == date {0}", date == DateTime.Today);

            Console.WriteLine("\n---------------------------------------------------\n");

            // exercice d'a\npplication
            Console.WriteLine("# exercice 1 #\n");

            Console.WriteLine("le date complete: {0}", now.ToString());
            Console.WriteLine("le date courte: {0}", now.ToString("d"));
            Console.WriteLine("24h format: {0}", now.ToString("g"));
            Console.WriteLine("personalise: {0}", now.ToString("MM/dd/yyyy HH:mm"));


            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine("# exercice 3 #\n");

            for (int year = 2000; year < 2021; year += 1)
            {
                DateTime lastDay = new DateTime(year, 12, 31);
                Console.Write("{0}: day {1} of {2}", lastDay.ToString("d"), lastDay.DayOfYear, year);
                if (DateTime.IsLeapYear(year))
                    Console.Write("(Leap Year)");

                Console.Write("\n");
            }

            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine("# exercice 4 #\n");

            DateTime[] dates = {
                DateTime.Now,
                new DateTime(2016, 8, 16, 9, 28, 0),
                new DateTime(2011, 5, 28, 10, 35, 0),
                new DateTime(1979, 12, 25, 14, 30, 0)
            };

            foreach (DateTime dateTime in dates)
            {
                Console.WriteLine("day: {0} Time: {1}", dateTime.ToString("d"), dateTime.TimeOfDay);
                Console.WriteLine("day: {0} Time: {1}", dateTime.ToString("d"), dateTime.ToString("HH:mm"));

                Console.Write("\n");
            }

            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine("# exercice 5 #\n");

            Console.WriteLine("Aujourd'hui = {0:d} {0:t}", now);
            Console.WriteLine("{0:dddd}", now.AddDays(40));

            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine("# exercice 7 #\n");

            double[] tab = { 0.08333, 0.16667, 0.25, 0.33333, 0.5, 0.66667, 1, 2, 29, 30, 31, 90, 365 };

            DateTime d = new DateTime(2016, 08, 16, 12, 0, 0, 0);

            foreach (var v in tab)
            {
                Console.WriteLine("{0} + {1} hour(s) = {2}", d, v, d.AddHours(v));
            }

            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine("# exercice 8 #\n");           

            DateTime lastAugustDay = new DateTime(2016, 08, 31);

            for (int i = 0; i < 16; i += 1)
            {
                Console.WriteLine("{0:d}", lastAugustDay.AddMonths(i));
            }

            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine("# exercice 9 #\n");

            DateTime lastFebDay = new DateTime(2016, 02, 29);

            Console.WriteLine("Base date:       {0:d}", lastFebDay);

            for (int i = 0; i < 16; i += 1)
            {
                Console.WriteLine("{0} year(s) ago:     {1:d}", i, lastFebDay.AddYears(-1 * i));
            }

            Console.Write("\n");

            for (int i = 0; i < 16; i += 1)
            {
                Console.WriteLine("{0} year(s) from now:    {1:d}", i, lastFebDay.AddYears(i));
            }

            Console.WriteLine("\n---------------------------------------------------\n");

            Console.WriteLine("# exercice 10 #\n");

            DateTime d1 = new DateTime(2016, 08, 01, 00, 00, 00);
            DateTime d2 = new DateTime(2016, 08, 01, 12, 00, 00);


            if (d1 > d2)
                Console.WriteLine("{0} est posterieur à {1}", d1, d2);
            else if(d1 < d2)
                Console.WriteLine("{0} est anterieur à {1}", d1, d2);
            else
                Console.WriteLine("{0} et {1} sont egaux", d1, d2);

        }
    }
}
