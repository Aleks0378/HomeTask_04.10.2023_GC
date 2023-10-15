using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal static class MyExtension
    {
        public static bool CheckIfOdd(this int num)
        {
            if (num % 2 == 0) return false;
            return true;
        }
    }
}
