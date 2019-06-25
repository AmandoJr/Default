using System;

namespace ConsoleNETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola mundo!");
            Console.Write("Informe o ano: ");
            var ano = Console.ReadLine();
            int valorAno = int.Parse(ano);
            int idade = DateTime.Today.Year - valorAno;
            Console.WriteLine($"\r\nSua idade: {idade}");
        }
    }
}

