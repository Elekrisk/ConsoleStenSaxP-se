using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStenSaxPåse
{
    public static class ConsoleIO
    {
        public static ConsoleColor DefaultColor { get; set; }

        public static void Write(string s)
        {
            Console.ForegroundColor = DefaultColor;
            Console.Write(" " + s);
        }
        public static void Write(object s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.Write(" " + s);
            Console.ForegroundColor = DefaultColor;
        }

        public static string ReadLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(">");
            Console.ForegroundColor = DefaultColor;
            return Console.ReadLine();
        }
        public static string ReadLine(bool allowEmpty)
        {
            string inp = "";
            while (true)
            {
                inp = ConsoleIO.ReadLine();
                if (allowEmpty || inp.Trim().Length > 0)
                {
                    return inp;
                }
                else
                {
                    Error("Input cannot be empty.");
                }
            }
        }
        public static string ReadLine(bool allowEmpty, string message)
        {
            string inp = "";
            while (true)
            {
                ConsoleIO.Write(message + "\n", ConsoleColor.Cyan);
                inp = ConsoleIO.ReadLine();
                if (allowEmpty || inp.Trim().Length > 0)
                {
                    return inp;
                }
                else
                {
                    Error("Input cannot be empty.");
                }
            }
        }

        public static int GetIntInput()
        {
            while (true)
            {
                try
                {
                    return int.Parse(ReadLine(false, "Please enter only numbers."));
                }
                catch (FormatException)
                {
                    Error("Only numbers are accepted.");
                }
            }
        }

        public static void Error(string errMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Error: " + errMessage);
            Console.ForegroundColor = DefaultColor;
        }
    }

    class Menu
    {
        public string MenuHeader { get; set; }
        public List<MenuOption> Options { get; } = new List<MenuOption>();

        public void StartLoop()
        {
            while (true)
            {
                Console.Clear();
            }
        }
    }

    class MenuOption
    {
        public string Option { get; set; }
        Action Function { get; set; }
    }
}
