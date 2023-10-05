using System;
using System.Globalization;
using System.Threading;

namespace SOAL_E
{
    class Program
    {
        static void Main()
        {
            string input = "SeLamAT PAGi semua halOo";

            // Format judul (title case)
            string titleCase = ToTitleCase(input);
            Console.WriteLine("Format Judul: " + titleCase);

            // Format biasa (lowercase)
            string lowercase = input.ToLower();
            string lowercasecustom = ToCustomLowerCase(lowercase);
            Console.WriteLine("Format Biasa: " + lowercasecustom);
            Console.ReadLine();
        }

        static string ToTitleCase(string input)
        {
            // Ubah ke format judul menggunakan TextInfo
            TextInfo textInfo = Thread.CurrentThread.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }

        static string ToCustomLowerCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] charArray = input.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }

    }
}
