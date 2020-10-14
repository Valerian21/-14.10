using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Результат: {x}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение FormatException");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
