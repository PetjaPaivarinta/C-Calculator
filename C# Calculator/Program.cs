using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   ____           _                  _           _                  \r\n  / ___|   __ _  | |   ___   _   _  | |   __ _  | |_    ___    _ __ \r\n | |      / _` | | |  / __| | | | | | |  / _` | | __|  / _ \\  | '__|\r\n | |___  | (_| | | | | (__  | |_| | | | | (_| | | |_  | (_) | | |   \r\n  \\____|  \\__,_| |_|  \\___|  \\__,_| |_|  \\__,_|  \\__|  \\___/  |_|   \r\n");
        
            Console.Write("Enter the first number: ");

            string FirstNumber = Console.ReadLine();


            if (FirstNumber != null)
            {
                int FirstNumberNum = Convert.ToInt32(FirstNumber);
                Console.Write("Enter the second number: ");

                string SecondNumber = Console.ReadLine();
                int SecondNumberNum = Convert.ToInt32(SecondNumber);

                if (SecondNumber != null)
                {
                    Console.WriteLine("What you wanna use to calculate?");
                    Console.WriteLine("Type + for add, - for take, * for multiply, / for divide");

                    string Method = Console.ReadLine();

                    if (Method == "+")
                    {
                        Console.WriteLine();
                        Console.WriteLine(FirstNumberNum + SecondNumberNum);
                    }
                    else if (Method == "-")
                    {
                        Console.WriteLine();
                        Console.WriteLine(FirstNumberNum - SecondNumberNum);
                    }
                    else if (Method == "*")
                    {
                        Console.WriteLine();
                        Console.WriteLine(FirstNumberNum * SecondNumberNum);
                    }
                    else if (Method == "/")
                    {
                        Console.WriteLine();
                        Console.WriteLine(FirstNumberNum / SecondNumberNum);
                    }
                    Console.ReadLine();
                }
            }


        }
    }
}
