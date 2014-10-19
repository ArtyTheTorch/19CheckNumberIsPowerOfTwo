using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19CheckNumberIsPowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(convertToBinary(num));
            Console.WriteLine(isPowerOfTwo(num));
            //Console.WriteLine(isPowerOfTwo(num));   
            Console.ReadLine();
        }

        private static bool isPowerOfTwo(int num)
        {
            bool results = true;
            double temp = convertToBinary(num);
            while (temp > 1)
            {
                if (temp % 10 > 0)
                {
                    results = false;
                    break;
                }
                temp = temp - temp % 10;
                temp = temp / 10;
            }
            
            return results;
        }

        private static double convertToBinary(int num)
        {
            int results = 0;
            Stack<int> digits = new Stack<int>();
            int temp = num;
            int f = 0;

            while (temp > 0) {
                digits.Push(temp % 2);
                temp = temp / 2;
            }

            //put the results into a string
            while (digits.Count !=0)
            {
                f = digits.Count - 1;
                results += digits.Pop() * Convert.ToInt32(Math.Pow(10,f));
            }
            return results;
        }
    }
}
