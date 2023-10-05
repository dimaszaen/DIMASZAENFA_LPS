using System;
using System.Collections.Generic;
using System.Linq;

namespace SOAL_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world";
            Console.WriteLine("Input: " + input);

            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c)) // Hanya memproses karakter alfabet
                {
                    if (characterCount.ContainsKey(c))
                    {
                        characterCount[c]++;
                    }
                    else
                    {
                        characterCount[c] = 1;
                    }
                }
            }

            foreach (var kvp in characterCount)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

            Console.ReadLine();
        }
    }
 }

