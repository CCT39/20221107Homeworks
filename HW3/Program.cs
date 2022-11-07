using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串：");
            string input = Console.ReadLine();
            string[] splitted = input.Split(',');

            int[] converted = new int[splitted.Length];

            for (int i = 1; i <= splitted.Length; i++)
            {
                converted[splitted.Length - i] = int.Parse(splitted[i - 1]);
            }

            Console.WriteLine(String.Join(",", converted));
            Console.ReadLine();
        }
    }
}
