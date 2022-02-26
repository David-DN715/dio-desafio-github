using System;
using exemploPOO.Models;

namespace ExemploPOO
{
    class Progam
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            r.DefinirMedida(30, 30);
            Console.WriteLine($"Àrea: {r.ObterArea()}");
            
            
            
            
            
            // Pessoa p1 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.apresentar();
        }
    }
}

