using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 8
//Створіть запис Point3D.
//Необхідно зберігати інформацію про координати точки у тривимірному просторі. 
//Створіть масив точок. Напишіть код для обчислення відстані між точками.
//Відобразіть максимальну відстань між точками та інформацію про них.
namespace Task_8
{
    internal static class MyExtension
    {
        public static float Distance(this Point3D p1, Point3D p2) 
        {
            return (float)Math.Sqrt(Math.Pow((p1.x - p2.x), 2) + Math.Pow((p1.y - p2.y), 2) + Math.Pow((p1.z - p2.z), 2));
        }
    }
}
