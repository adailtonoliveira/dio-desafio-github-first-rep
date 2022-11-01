using System;
using Desafio1.Models;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Associado assoc1 = new Associado();
            assoc1.Nome = "Adailton";

            Console.WriteLine("Hello World!");
            Console.WriteLine("Associado: {0}", assoc1.Nome);
        }
    }
}
