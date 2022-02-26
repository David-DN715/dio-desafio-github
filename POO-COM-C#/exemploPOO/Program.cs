using System;
using exemploPOO.Models;

namespace ExemploPOO
{
    class Progam
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Bob";
            p1.Idade = 20;

            p1.apresentar();
        }
    }
}

