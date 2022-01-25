using System;
using EstruturaDoPrograma.Exemplos;
//aqui passamos a empilhar os dados, e depois imprimimos o desempilhar 
namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}