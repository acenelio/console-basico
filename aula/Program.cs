using System;
using System.Globalization;

namespace aula {
    class Program {
        static void Main(string[] args) {

            double x;

            Console.Write("Digite um numero: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Numero digitado = " + x);

            Console.ReadLine();
        }
    }
}
