using System;

namespace HW_Delegates
{
    class Program
    {
        static void Main()
        {
            MyCalculator.Calculator();
            Console.ReadKey();
        }
    }

    static class MyCalculator
    {
        delegate double MyDelegate(double op1, double op2);

        static MyDelegate addition = (op1, op2) =>
        {
            return op1 + op2;
        };

        static MyDelegate substraction = (op1, op2) =>
        {
            return op1 - op2;
        };

        static MyDelegate multiplication = (op1, op2) =>
        {
            return op1 * op2;
        };

        static MyDelegate division = (op1, op2) =>
        {
            if (op2 == 0)
            {
                Console.WriteLine("Division by zero!");
            }
            return op1 / op2;
        };

        public static double Calculate(double op1, double op2, char oprtr)
        {
            double result = 0;
            switch (oprtr)
            {
                case '+':
                    result = addition(op1, op2);
                    break;
                case '-':
                    result = substraction(op1, op2);
                    break;
                case '*':
                    result = multiplication(op1, op2);
                    break;
                case '/':
                    result = division(op1, op2);
                    break;
                default:
                    Console.WriteLine("Can't calculate!");
                    break;
            }
            return result;
        }

        public static void Calculator()
        {
            double operand1 = 0;
            double operand2 = 0;
            double result = 0;
            char oprtr = ' ';

            try
            {
                Console.Write("Enter operand1: ");
                operand1 = Double.Parse(Console.ReadLine());
                Console.Write("\nEnter operator: ");
                oprtr = Char.Parse(Console.ReadLine());
                Console.Write("\nEnter operand2: ");
                operand2 = Double.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            result = Calculate(operand1, operand2, oprtr);
            if (result != Double.PositiveInfinity & result != Double.NegativeInfinity)
                Console.WriteLine("\nResult: " + result);
        }
    }
}
