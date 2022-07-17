using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public static class Extension
    {
        public static bool CheckNotRobotCode(this string word, int size)
        {
            if (word.Length > size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
