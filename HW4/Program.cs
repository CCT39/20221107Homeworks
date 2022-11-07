using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入數字（1-9）");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = input; i > 0; i--)
            {
                int numOfNums = input - i + 1;

                for (int j = 1; j <= numOfNums; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}