using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); //Ele vai colocar ponto no lugar da vírgula.

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            //Concatenação.
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            //PlaceHolders.
            Console.WriteLine("{0} tem {1} anos, logo ele nasceu em {2}.","Luiz", 20, 2000);
            //Interpolação.
            Console.WriteLine($"{z} tem {y} anos, logo ele nasceu em {DateTime.Now.Year-y}.");

            Console.ReadLine();
        }
    }
}
