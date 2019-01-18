using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Input first number for calculation");
                double firstnumber = inputConverter.InputToNum(Console.ReadLine());
                
                Console.WriteLine("+, -, *, /");
                string operation = Console.ReadLine();

                Console.WriteLine("Input second number for calculation");
                double secondnumber = inputConverter.InputToNum(Console.ReadLine());

                double result = calculatorEngine.Calculate(operation, firstnumber, secondnumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
