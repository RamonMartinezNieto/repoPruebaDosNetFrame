using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            int resultado = c.suma(5, 5);
            Console.WriteLine(resultado);

        }
    }
}
