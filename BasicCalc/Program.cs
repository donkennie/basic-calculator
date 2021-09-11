using System;

namespace BasicCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                double result1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter operator: ");
                string op = Console.ReadLine();

                Console.WriteLine("Enter a number: ");
                double result2 = double.Parse(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine("The answer is: " + result1 + result2);
                }
                else if (op == "-")
                {
                    Console.WriteLine(result1 - result2);

                }
                else if (op == "/")
                {
                    Console.WriteLine(result1 / result2);

                }
                else if (op == "*")
                {
                    Console.WriteLine("The answer is: " + result1 * result2);

                }
                else if (op == "%")
                {
                    Console.WriteLine(result1 % result2);

                }

                else
                {
                    Console.WriteLine("Invalid operator");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
        }
    }
}
