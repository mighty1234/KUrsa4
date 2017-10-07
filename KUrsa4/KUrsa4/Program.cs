using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());  // int.Parse - статический метод, который преобразует 
            int b = int.Parse(Console.ReadLine());  // переменную типа строка в целое число.
            Console.WriteLine(a + b);
            Console.ReadKey();  // пауза консоли
        }
    }
}
