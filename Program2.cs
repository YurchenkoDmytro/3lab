using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;

            Console.WriteLine("Введіть число:");
            string input = Console.ReadLine();

            int maxDigit = int.MinValue;
            int minDigit = int.MaxValue;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    maxDigit = Math.Max(maxDigit, digit);
                    minDigit = Math.Min(minDigit, digit);
                }
            }

            Console.WriteLine($"Максимальна цифра: {maxDigit}");
            Console.WriteLine($"Мінімальна цифра: {minDigit}");

            Console.ReadKey();


        }
    }
}
