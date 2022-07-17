using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            string word = "havj";
            Console.WriteLine(word.CheckNotRobotCode(4));

            User user1 = new User(100, "Namiq", "Mamedov", "gtdx", 1);
            Console.WriteLine(user1.GetDetails());
            User user2 = new User(100, "Aqil", "Huseynov", "ckds", 4);
            Console.WriteLine(user2.GetDetails());

            int month = 1;
            switch (month)
            {
                case (int)Month.January:
                    Console.WriteLine("January");
                    break;
                case (int)Month.February:
                    Console.WriteLine("February");
                    break;
                case (int)Month.March:
                    Console.WriteLine("March");
                    break;
                case (int)Month.April:
                        Console.WriteLine("April");
                    break;
                case (int)Month.May:
                        Console.WriteLine("May");
                    break;
                case (int)Month.June:
                    Console.WriteLine("June");
                    break;
                case (int)Month.July:
                    Console.WriteLine("July");
                    break;
                case (int)Month.August:
                    Console.WriteLine("August");
                    break;
                case (int)Month.September:
                    Console.WriteLine("September");
                    break;
                case (int)Month.October:
                    Console.WriteLine("October");
                    break;
                case (int)Month.November:
                    Console.WriteLine("November");
                    break;
                case (int)Month.December:
                    Console.WriteLine("December");
                    break;
                default:
                    break;
                    
            }
        }

            public enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
    
}


