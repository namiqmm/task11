using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class User 
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NotRobotCode { get; set; }
        public int RegistrationMonth { get; set; }

       
        public User(int id, string name, string surname, string notRobotCode, int registrationMonth)
        {
            Id++;
            Name = name;
            Surname = surname;
            Id = id;
            NotRobotCode = notRobotCode;
            RegistrationMonth = registrationMonth;
        }

             
        public string GetDetails()
        {
            return $"Name:{Name} Surname:{Surname} ID:{Id} RegistrationMonth:{RegistrationMonth} NotRobotcode:{NotRobotCode}";
        }

        
    }

}


