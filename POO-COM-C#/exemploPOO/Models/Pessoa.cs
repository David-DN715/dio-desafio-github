using System;

namespace exemploPOO.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}

        public int Idade {get; set;}

        public void apresentar()
        
            {
                Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos!");
            }
    }
}