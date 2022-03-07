using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите кол-во треугольников");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        string b = new String('*', j);
                        Console.WriteLine(b.PadLeft(n) + "*" + b);
                    }
                }
            }
            else
                Console.WriteLine("введите коректное число");
        }
    }
}
