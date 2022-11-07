using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串：");
            string input = Console.ReadLine();
            string[] splitted = input.Split(',');

            int[] converted = Array.ConvertAll(splitted, int.Parse);
            Array.Sort(converted);

            string[] odds = new string[converted.Length];
            string[] evens = new string[converted.Length];
            int oddIndex = 0;
            int evenIndex = 0;

            for (int i = 0; i < converted.Length; i++)
            {
                if (converted[i] % 2 == 1)
                {
                    odds[oddIndex] = converted[i].ToString();
                    oddIndex++;
                }
                else
                {
                    evens[evenIndex] = converted[i].ToString();
                    evenIndex++;
                }
            }

            Array.Resize(ref odds, oddIndex);
            Array.Resize(ref evens, evenIndex);

            Console.WriteLine("奇數：" + String.Join(",", odds));
            Console.WriteLine("偶數：" + String.Join(",", evens));

            Console.ReadLine();
        }
    }
}
