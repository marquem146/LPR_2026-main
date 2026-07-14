using System;
using System.Collections.Generic;
namespace exercicios
{
class program1
{
    
    static void Main()
    {
      List<int> notas = new();
      for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("notas: ");
                string aluno1 = Console.ReadLine() ?? string.Empty;
                string aluno2 = Console.ReadLine() ?? string.Empty;
                string aluno3 = Console.ReadLine() ?? string.Empty;
                int nota1 = int.Parse(aluno1);
                int nota2 = int.Parse(aluno2);
                int nota3 = int.Parse(aluno3);
                notas.Add(nota1);
                notas.Add(nota2);
                notas.Add(nota3);

                if(nota3 > nota2 && nota3> nota1)
                {
                    Console.WriteLine("a maior nota é:"+ nota3);
                }
                else if(nota2 > nota3 && nota2> nota1)
                {
                    Console.WriteLine("a maior nota é:"+ nota2);
                }
                else if(nota1 > nota3 && nota1 > nota2)
                {
                    Console.WriteLine("a maior nota é:"+ nota1);
                }
                else
                {
                  Console.WriteLine("não houve uma nota maior");
                }
            }
    }
}    
}
