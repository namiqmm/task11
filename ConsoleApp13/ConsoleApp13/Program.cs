using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {            
            User user1 = new User("Eli","Kazimov","4K12",Month.April);
            Console.WriteLine(user1.GetDetails());
            User user2 = new User("Namiq", "Mamedov", "8KNQW2", Month.October);\
            Console.WriteLine(user2.GetDetails());
                        
        }

       
    }
    
}
