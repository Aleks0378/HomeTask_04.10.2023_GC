using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal static class MyExtension
    {
        public static bool AgeBiggerThan(this Person p1, Person p2)
        {
           return p1.Age > p2.Age ? true : false;
        }
        public static bool AgeSmallerThan(this Person p1, Person p2)
        {
            return p1.Age < p2.Age ? true : false;
        }
        public static double AverangeAge(this Person[] p)
        {
            double temp = 0;
            for (int i = 0; i < p.Length; i++) temp += p[i].Age;
            //Console.WriteLine(temp);
            return (temp/p.Length);
        }
    }
}
