using System;

namespace SOAL_D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 5 == 0 && i != 5)
                {
                    Console.Write("IDIC ");
                }
                else if (i % 6 == 0 && i != 6)
                {
                    Console.Write("LPS ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
