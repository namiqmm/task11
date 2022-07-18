using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
   public static class Extension
    {
        public static bool CheckNotRobotCode(this string word)
        {
            if (word.Length == 4 )
            {
                return false;
                Console.WriteLine("Symbol duzgun oturulmuyub");
            }
            else
            {
                return true;
            }
        }
}
