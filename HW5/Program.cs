using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入民國年份：");
            int yearCommomEra = int.Parse(Console.ReadLine()) + 1911;

            if (DateTime.IsLeapYear(yearCommomEra))
                Console.WriteLine("是閏年");
            else
                Console.WriteLine("是平年");
            Console.ReadLine();
        }
    }
}
