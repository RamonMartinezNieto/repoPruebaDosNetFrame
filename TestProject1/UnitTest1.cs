using NUnit.Framework;
using ConsoleApp1;
using System;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

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