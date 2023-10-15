//Завдання 8
//Створіть запис Point3D.
//Необхідно зберігати інформацію про координати точки у тривимірному просторі. 
//Створіть масив точок. Напишіть код для обчислення відстані між точками.
//Відобразіть максимальну відстань між точками та інформацію про них.
using Task_8;
Random rand = new Random();
Point3D[] points = new Point3D[10];
Console.WriteLine("\n All Points: ");
for (int i = 0; i < points.Length; i++)
{
    points[i] = new(rand.Next(0,50), rand.Next(0,50), rand.Next(0,50));
    Console.WriteLine(points[i]);
}
Point3D p1 = points[0], p2 = points[1];
float Max = p1.Distance(p2);
for (int i = 0; i < points.Length; i++)
    for (int j = 0; j < points.Length; j++)
        if (i!=j && points[i].Distance(points[j])>Max) 
        {
            Max = points[i].Distance(points[j]);
            p1= points[i];
            p2= points[j];
        }
Console.WriteLine($"\n The maximum distance {Max} between points {p1} and {p2}");