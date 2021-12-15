using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action action = new Action(Method1);
            //Task task1 = new Task(action);

            //Action<Task> actionT = new Action<Task>(Method2);
            //Func <int, int[]> func = Method1(10);
            //Task task = new Task(func);
            //Task task2 = task1.ContinueWith(actionT);

            //task1.Start();
            //task2.Wait();
            Method1();

            Console.WriteLine("Основной поток завершен");
            Console.ReadKey();
        }

        static int[] Method1()
        {
            Console.WriteLine("Пуск Метод 1");
            Console.WriteLine("Ввести целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-20, 20);
                Console.Write($"{array[i]}" + " ");               
            }           
            Console.WriteLine("Метод 1 закончен");
            return array;
        }
        //static void Method2(Func <object, int>)
        //{

        //    int[] array = (int[])object;
        //    int sum = 0;
        //    int max = 0;

        //    for (int i = 0; i < n; i++)
        //    {
                
        //        Console.Write($"{array[i]}" + " ");

        //        if (array[i] > max)
        //            max = array[i];
        //    }

        //    Console.WriteLine($"\nМаксимальное число: {max}");
        //    Console.WriteLine("Метод 2 закончен");
        //}
    }
    
}
