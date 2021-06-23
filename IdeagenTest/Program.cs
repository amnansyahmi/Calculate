using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeagenTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(@"Please Enter your equation : ");
            string equation = Console.ReadLine();

            double result = Convert.ToDouble(new DataTable().Compute(equation, null));

            var stringResult = result.ToString();
            Console.WriteLine("Result: " + stringResult);
            Console.ReadLine();
        }
    }
}