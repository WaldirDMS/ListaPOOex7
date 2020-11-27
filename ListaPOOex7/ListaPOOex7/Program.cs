using System;

namespace ListaPOOex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolar;

            dolar = new Dolar();

            Console.Write("Informe a cotação ");
            dolar.setCot(double.Parse(Console.ReadLine()));

            Console.Write("Informe o valor em dolares ");
            dolar.setDol(double.Parse(Console.ReadLine()));

            dolar.converterMoeda();

            Console.WriteLine("O valor {0} em dolares é correspontende a {1} reais", dolar.getDol(), dolar.getReal());
        }
    }
}
