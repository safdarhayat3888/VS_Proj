using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t");
            Console.WriteLine(" \t\t\t-------------Console Calculator in C#------------------- \r");
            Console.WriteLine("\t\t\t----------------------------------------------------------\r");
            double num1 = 0, num2 = 0, result = 0;
            string ops, choice;

            {
                Console.WriteLine("\t\t\tConsole Calculator App.\n");



                Console.Write("\t\t\tEnter first number : ");
                num1 = Convert.ToDouble(Console.ReadLine());



                Console.Write("\t\t\tSelect operator (+,-,*,/,^,p,%,sq) : ");
                ops = Console.ReadLine();



                if (ops != "sq")
                {
                    Console.Write("\t\t\tEnter second number : ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                if (ops == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine("\t\t\t" + result);
                }
                else if (ops == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine("\t\t\t" + result);
                }
                else if (ops == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine("\t\t\t" + result);
                }
                else if (ops == "/")
                {
                    result = num1 / num2;
                    Console.WriteLine("\t\t\t" + result);
                }
                else if (ops == "p")
                {
                    result = ((num1 / 100) * num2);
                    Console.WriteLine("\t\t\t" + result);
                }
                else if (ops == "^")
                {
                    result = Math.Pow(num1, num2);
                    Console.WriteLine("\t\t\t" + result);
                }
                else if (ops == "%")
                {
                    result = num1 % num2;
                    Console.WriteLine("\t\t\t" + result);
                }
                else if (ops == "sq")
                {
                    result = Math.Sqrt(num1);
                    Console.WriteLine("\t\t\t " + result);
                }
                else
                {
                    Console.WriteLine("\t\t\tInvalid Operator!");
                }
                Console.WriteLine("\t\t\t---------------------------------------------------------------------\n");
                Console.Write("\t\t\tPress (Y) to continue or any other key to exit : ");
                choice = Console.ReadLine();
                Console.Clear();
            } while (choice == "Y" || choice == "y") ;
        }
    }
}