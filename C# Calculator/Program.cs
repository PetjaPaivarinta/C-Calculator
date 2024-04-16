using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class Program
    {
        static void ErrorTryAgain()
        {
            Console.WriteLine("Invalid method!");
            Console.WriteLine("Please try again");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("   ____           _                  _           _                  \r\n  / ___|   __ _  | |   ___   _   _  | |   __ _  | |_    ___    _ __ \r\n | |      / _` | | |  / __| | | | | | |  / _` | | __|  / _ \\  | '__|\r\n | |___  | (_| | | | | (__  | |_| | | | | (_| | | |_  | (_) | | |   \r\n  \\____|  \\__,_| |_|  \\___|  \\__,_| |_|  \\__,_|  \\__|  \\___/  |_|   \r\n");

            Console.Write("Enter the first number: ");

            int FirstNumber = Convert.ToInt32(Console.ReadLine());


           
                Console.Write("Enter the second number: ");

                int SecondNumber = Convert.ToInt32(Console.ReadLine());

                
                    Console.WriteLine("What you wanna use to calculate?");
                    Console.WriteLine("Type + for add, - for take, * for multiply, / for divide");
                    Console.WriteLine();

                    Console.Write("Method: ");

                    string Method = Console.ReadLine();
                    if (Method.Length > 1)
                    {
                        ErrorTryAgain();
                        Console.Write("Method: ");
                        Method = Console.ReadLine();
                    }

                    switch(Method)
            {
                        case "+":
                            Console.WriteLine();
                            Console.WriteLine(FirstNumber + SecondNumber);
                            break;
                        case "-":
                            Console.WriteLine();
                            Console.WriteLine(FirstNumber - SecondNumber);
                            break;
                        case "*":
                            Console.WriteLine();
                            Console.WriteLine(FirstNumber * SecondNumber);
                            break;
                        case "/":
                            Console.WriteLine();
                            Console.WriteLine(FirstNumber / SecondNumber);
                            break;
                        default : 
                            ErrorTryAgain();
                    Console.Write("Method: ");
                    Method = Console.ReadLine();
                    break;
                    }

                   
                    Console.WriteLine();
                    Console.Write("Type restart to restart the program: ");
                    string Restart = Console.ReadLine();
                    Restart.ToLower();
                    if (Restart == "restart")
                    {
                        Console.Clear();
                        Main(args);
                    }
                
        }

    }
}
