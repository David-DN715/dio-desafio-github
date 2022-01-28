using System;

namespace Revisao
{
    class Progam
    {   
        static void Main(string[] args)
        {
            string opcaousuario = obteropcaousuario();

            while (opcaousuario.ToUpper() != "X")
            {
                switch (opcaousuario)
                {
                    case "1":
                    //TODO: adicionar aluno!
                    
                        break;
                    case "2":
                    //TODO: Listar alunos!

                        break;
                    case "3":
                    //TODO: Calcular media geral!

                        break; 
                    default:
                        throw new ArgumentOutOfRangeException();

                }   

                        opcaousuario = obteropcaousuario();
            }

        }
        private static string obteropcaousuario()
        {   
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - listar alunos");
            Console.WriteLine("3 - calcular media geral");
            Console.WriteLine("x - sair");
            Console.WriteLine();

            string opcaousuario = Console.ReadLine();
            return opcaousuario;
        }   
    }   
}