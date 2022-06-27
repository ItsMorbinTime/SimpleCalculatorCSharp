using System;

namespace SimpleCalculator
{
    class Simple
    {
        static void Main(string[] args)
        {
            long num1;
            long num2;
            double result;
            
            try {
                Console.WriteLine("Input A Number: ");
                num1  =  Convert.ToInt32(Console.ReadLine());    
            } catch (Exception e) {
                Console.WriteLine("Error occured!");
                return;
            }
            
            try {
                Console.WriteLine("Input A Second Number: ");
                num2  =  Convert.ToInt32(Console.ReadLine());    
            } catch (Exception e) {
                Console.WriteLine("Error occured!");
                return;
            }

            Console.WriteLine("Select A Calculation Mode:\n" +
                            "+ = Add\n" +
                            "- = Substract\n" +
                            "* = Multiply\n" +
                            "/ = Divide");

            switch(Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;
                case "/":
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
                break;

                default:
                    Console.WriteLine("Input is not valid!");
                    break;
                
            }
        }
    }
}