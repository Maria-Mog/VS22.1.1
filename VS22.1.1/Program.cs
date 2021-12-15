using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VS22._1._1
{
    class Program
        
    {        
        static void Main(string[] args)
        {
            Action action = new Action(Method1);
            Task task1 = new Task(action);

            Action<Task> actionT = new Action<Task>(Method2);
            Task task2 = task1.ContinueWith(actionT);

            task1.Start();
            task2.Wait();

            Console.WriteLine("Основной поток завершен");
            Console.ReadKey();
        }

        static void Method1()
        {
            Console.WriteLine("Пуск Метод 1");
            Console.WriteLine("Ввести целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-20, 20);
                Console.Write($"{array[i]}" + " ");
                sum += array[i];
            }
            Console.WriteLine($"\nСумма: {sum}");
            Console.WriteLine("Метод 1 закончен");
        }
        static void Method2(Task t)
        {
            Console.WriteLine("\nПуск Метод 2");
            Console.WriteLine("Ввести целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-20, 20);
                Console.Write($"{array[i]}" + " ");

                if (array[i] > max)
                    max = array[i];
            }

            Console.WriteLine($"\nМаксимальное число: {max}");
            Console.WriteLine("Метод 2 закончен");
        }

    }
}
