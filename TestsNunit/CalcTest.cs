using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp1;


namespace TestsNunit
{
    [TestFixture]
    class CalcTest
    {
        [Test]
        public void TestSuma()
        {
            Console.WriteLine("Iniciando Test Suma");
            Calculadora c = new Calculadora();

            int resultado = c.suma(5, 5);

            Assert.That(resultado, Is.EqualTo(10));

            Console.WriteLine("Fin del test suma ");
        }
    }
}
