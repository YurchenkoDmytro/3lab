using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastmass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            int[][] jagged = new int[4][];
            jagged[0] = new int[] { 1, 2, -3, 4, 5, -6 };
            jagged[1] = new int[] { 7, 8 };
            jagged[2] = new int[] { 9, 10, 11, -12 };
            jagged[3] = new int[] { };

            double sum = 0;
            int count = 0;
            foreach (int[] arr in jagged)
            {
                int currentLength = 0;
                int maxLength = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 0)
                    {
                        currentLength++;
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                    }

                    if (maxLength > 0)
                    {
                        Console.Write(arr[i] + " ");
                        maxLength--;
                        sum++;
                        count++;
                    }
                }
                Console.WriteLine();
            }

            double averageLength = count > 0 ? sum / count : 0;
            Console.WriteLine("Середня довжина неперервних додатних послідовностей: " + averageLength);


        }
    }
}
