using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTasks
{
    class CT
    {
        public static void Header(string x, string y, string z)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int h = 60;
            bool check = true;
            while (check)
                try
                {
                    Console.SetWindowSize(100, h);
                    check = false;
                }
                catch (Exception)
                {
                    h--;
                    check = true;
                }
            Console.SetWindowSize(100, h);
            Console.WriteLine("Date: {0}"
           + "\t\t\tTitle: {1}"
           + "\t\tAuthor: Mitchell Gribman\n\n", x, y);
            Console.WriteLine("Purpose: To {0}\n", z);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************************************"
           + "*******************************************************\n\n");
        }

        public static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nGoodbye!");
            Console.Read();
        }

        public static string AskUserForString(string x)
        {
            Console.Write("Please input {0}: ", x);
            string input = Console.ReadLine();
            return input;
        }

        public static double AskUserForDouble(string x)
        {
            Console.Write("Please input {0}: ", x);
            string input = Console.ReadLine();
            double doubleInput = Convert.ToDouble(input);
            return doubleInput;
        }

        public static int AskUserForInt(string x)
        {
            Console.Write("Please input {0}: ", x);
            string input = Console.ReadLine();
            int intInput = Convert.ToInt32(input);
            return intInput;
        }

        public static void CreateBorderLine(string x)
        {
            int y = x.Length;
            Console.WriteLine("");

            for (int i = 0; i < y; i++)
            {
                Console.Write("*");
            }
        }
    }
}