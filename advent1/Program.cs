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
            //// ===== Day 1 Part 1 =====

            //int count = 0;
            //string[] lines = File.ReadAllLines(@"C:\Users\vikke\source\repos\advent\advent1\advent1\Text.txt");

            //int[] numbers = new int[lines.Length];
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    numbers[i] = Convert.ToInt32(lines[i]);
            //}

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    if (numbers[i + 1] > numbers[i])
            //    {
            //        count++;
            //    }
            //}

            //// ===== Day 1 Part 2 =====

            //int count1 = 0;
            //for (int i = 0; i < numbers.Length - 3; i++)
            //{
            //    int Value1 = numbers[i] + numbers[i + 1] + numbers[i + 2];
            //    int Value2 = numbers[i + 1] + numbers[i + 2] + numbers[i + 3];
            //    if (Value2 > Value1)
            //    {
            //        count1++;
            //    }
            //}

            //// ===== Day 2 Part 1 =====

            //string[] commands = File.ReadAllLines(@"C:\Users\vikke\source\repos\advent\advent1\advent1\commands.txt");

            //// Up = decreases depth
            //// Down = increases depth

            //int forwardX = 0, depth = 0, sum = 0;

            //for (int i = 0; i < commands.Length; i++)
            //{
            //    string[] splitWord = commands[i].Split(' ');

            //    if (splitWord[0] == "forward")
            //    {
            //        int forwardVal = Convert.ToInt32(splitWord[1]);

            //        forwardX += forwardVal;
            //    }

            //    if (splitWord[0] == "down")
            //    {
            //        int downVal = Convert.ToInt32(splitWord[1]);
            //        depth += downVal;
            //    }

            //    if (splitWord[0] == "up")
            //    {
            //        int upVal = Convert.ToInt32(splitWord[1]);
            //        depth -= upVal;
            //    }
            //    sum = forwardX * depth;
            //    Console.WriteLine(sum);
            //}

            // ===== Day 2 Part 2 =====

            // down X increases aim
            // up X decreases aim
            // forward X It increases horizontal position, It increases depth by your aim multiplied by X ( depth = aim * forward X )

            int aimValue = 0, forwardX = 0, depth = 0, tempDepth = 0;

            string[] aimCommands = File.ReadAllLines(@"C:\Users\vikke\source\repos\advent\advent1\advent1\commands.txt");

            for (int i = 0; i < aimCommands.Length; i++)
            {
                string[] aim = aimCommands[i].Split(' ');

                if (aim[0] == "forward")
                {
                    int forwardVal = Convert.ToInt32(aim[1]);
                    forwardX += forwardVal;

                    depth += aimValue * forwardVal;
                }

                if (aim[0] == "down")
                {
                    int downVal = Convert.ToInt32(aim[1]);
                    aimValue += downVal;
                }

                if (aim[0] == "up")
                {
                    int upVal = Convert.ToInt32(aim[1]);
                    aimValue -= upVal;
                }
                int sum = depth * forwardX;
                Console.WriteLine(sum);
            }

            //Console.WriteLine(count);
            //Console.WriteLine(count1);
            Console.ReadLine();
        }
    }
}
