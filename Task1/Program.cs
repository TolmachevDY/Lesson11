using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Решение линейного уравнения kx+b=0\nk=");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());

            Line line = new Line(k, b);
            Console.WriteLine("х={0}",line.Root());
            Console.ReadKey();
        }
    }
}
