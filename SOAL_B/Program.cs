using System;

namespace SOAL_B
{
    class Program
    {
        static void Main()
        {
            int angka = 1225441; // Nilai input
            Console.WriteLine("Input nilai: " + angka);

            int divisor = 1000000; // Divisor awal untuk satuan jutaan

            while (divisor >= 1)
            {
                int hasilBagi = angka / divisor;
                if (hasilBagi > 0)
                {
                    Console.WriteLine(hasilBagi * divisor);
                }

                angka %= divisor;
                divisor /= 10;
            }
            Console.ReadLine();
        }
    }
}
