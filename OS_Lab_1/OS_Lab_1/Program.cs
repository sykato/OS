using System;
using System.Threading;

namespace os_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(worker);
            myThread.Start();

            Console.Write("Размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] mass = new int[size];
            for (int i = 0; i < size; i++)
            {
                mass[i] = random.Next(10);
                Console.WriteLine(mass[i]);
            }
        }

        static void worker()
        {
            for (int i = 0; i < 10; i++)
            {

            }
        }
    }
}