using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {            
            User user1 = new User("Eli","Kazimov","4K12",Month.April);
            Console.WriteLine(user1.GetDetails());
            User user2 = new User("Namiq", "Mamedov", "8KNQW2", Month.October);
            Console.WriteLine(user2.GetDetails());            
            User user3 = new User("Resad", "Ibrahimov, "42K3", Month.February);
            Console.WriteLine(user3.GetDetails());
            User user4 = new User("Aqil", "Huseynov", "DK3F", Month.May);
            Console.WriteLine(user4.GetDetails());
            User user5 = new User("Vaqif", "Aliyev", "30J1", Month.July);
            Console.WriteLine(user5.GetDetails());                      
                                  
                                  
                                  
                                  
                        
        }

       
    }
    
}
