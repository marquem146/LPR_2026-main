using System;
using System.Collections.Generic;
using System.Security.AccessControl;
namespace aula09
{
    class exercicio1
    {
        static void Main(string[] args)
        {
          List<int> notas = new();
          Console.WriteLine("digite as notas dosa alunos: Maria, Joao, Cesar, luciana e Jeferson");
          notas.Add = Convert.ToInt32(Console.ReadLine());
          notas.Add = Convert.ToInt32(Console.ReadLine());
          notas.Add = Convert.ToInt32(Console.ReadLine());
          notas.Add = Convert.ToInt32(Console.ReadLine());
          notas.Add = Convert.ToInt32(Console.ReadLine());
          foreach(var cadras in notas)
            {
                Console.WriteLine(cadras);
            }
            Console.WriteLine("aqui etsa as notas" + cadras);
        }
    }
}
