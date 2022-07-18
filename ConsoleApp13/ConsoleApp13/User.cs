using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{

        public class User
        {
            private static int id;
            public int ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string NotRobotCode { get; set; }

            public Month RegistrationMonth { get; set; }
            


            public User( string name, string surname, string notRobotCode, Month registrationMonth)
            {
                id++;
                ID = id;
                Name = name;
                Surname = surname;
                NotRobotCode = notRobotCode;
                RegistrationMonth = registrationMonth;
            }
            public User()
            {

            }

            public string GetDetails()
            {
                

                if (NotRobotCode.CheckNotRobotCode())
                {
                    return $"Name:{Name} Surname:{Surname} ID:{id} RegistrationMonth:{RegistrationMonth} NotRobotcode:{NotRobotCode}";
                }
                else
                {
                    return $"Name:{Name} Surname:{Surname} ID:{id} RegistrationMonth:{RegistrationMonth} NotRobotcode:{NotRobotCode}";
                }
            }


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




