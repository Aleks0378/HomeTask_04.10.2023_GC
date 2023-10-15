using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 2
//Створіть метод розширення (extension method) для
//перевірки цілого числа на парність. Напишіть код для 
//тестування методу.
namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[30];
            Random random = new Random();
            Console.WriteLine("\n Массив случайных целых чисел: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 50);
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("\n Все непарные числа массива: ");
            foreach (int i in arr) if (i.CheckIfOdd()) Console.Write(i + ", ");
            Console.WriteLine("\n Все парные числа массива: ");
            foreach (int i in arr) if (i.CheckIfEven()) Console.Write(i + ", ");
            Console.WriteLine("\n\n");
        }
    }
}
