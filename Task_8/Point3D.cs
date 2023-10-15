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
   public record Point3D(int x,int y,int z);
}
