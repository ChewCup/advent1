using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== Day 1 Part 1 ===== 

            int count = 0;
            
            string[] lines = File.ReadAllLines(@"C:\Users\vikke\source\repos\advent\advent1\advent1\Text.txt");

            int[] numbers = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = Convert.ToInt32(lines[i]);
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] > numbers[i])
                {
                    count++;
                }
            }

            // ===== Day 1 Part 2 =====

            int count1 = 0;
            for (int i = 0; i < numbers.Length - 3; i++)
            {
                int Value1 = numbers[i] + numbers[i + 1] + numbers[i + 2];
                int Value2 = numbers[i + 1] + numbers[i + 2] + numbers[i + 3];
                if (Value2 > Value1)
                {
                    count1++;
                }
            }

            // ===== Day 2 =====

            string[] commands = File.ReadAllLines(@"C:\Users\vikke\source\repos\advent\advent1\advent1\commands.txt");

            foreach (var command in commands)
            {
                Console.WriteLine(command);
            }
            Console.WriteLine(count);
            Console.WriteLine(count1);
            Console.ReadLine();
        }
        


    }
}
