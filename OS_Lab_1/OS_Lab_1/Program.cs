using System;
using System.Threading;


namespace os_lab1
{
    class Program
    {
        static int [] mass { get; set; }
        static double srZnach { get; set; }
        static void Main()
        {

            Console.Write("Размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            mass  = new int[size];

            Random random = new Random();
            
            int max = 0;
            int min = 10;
            for (int i = 0; i < size; i++)
            {
                mass[i] = random.Next(10);
                Console.WriteLine($"[{i}] = {mass[i]}");
                if (mass[i] > max)
                {
                    max = mass[i];
                    Thread.Sleep(7);
                }
                if (mass[i] < min)
                {
                    min = mass[i];
                    Thread.Sleep(7);
                }
            }
            Thread Main = new Thread(Worker);
            Main.Start();

            Console.WriteLine($"\nМинимальное число: {min}\nМаксимальное число: {max}\n");
            Main.Join();
            Console.WriteLine($"\nid потока Main: {Main.ManagedThreadId}\n");

            var overSrZnach = 0;
            for(int i = 0; i < mass.Length; i++)
            if (srZnach < mass[i])
            {
                overSrZnach++;
            }
            Console.WriteLine($"\nКол-во элементов в массиве, значение которых больше среднего значения элементов массива: {overSrZnach}\n");
        }

        static void Worker()
        {
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                summ += mass[i];
                Thread.Sleep(12);
            }
            srZnach = summ / mass.Length;
            Console.WriteLine($"\nСреденне значение: { srZnach}\n");

            List<int> evenNumber = new List<int>();

            for (int i = 0; i < mass.Length; i++)
            {
                if(mass[i] % 2 == 0)
                {
                    evenNumber.Add(mass[i]);
                }
            }
            int count = evenNumber.Count;
            string concat = string.Join(",", evenNumber.ToArray());
            Console.WriteLine($"Четные число массива: {concat}");
        }
    }
}