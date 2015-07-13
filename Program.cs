using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число в двоичной для его перевода в восьмеричную, десятичную, шестнадцатеричную системы соответственно:");
      

            string a = Console.ReadLine();

            Console.WriteLine(Convert.ToString(Convert.ToInt32(a, 2), 8));
            Console.WriteLine(Convert.ToString(Convert.ToInt32(a, 2), 10));
            Console.WriteLine(Convert.ToString(Convert.ToInt32(a, 2), 16));
            
            Console.ReadKey();
        }
    }
}
