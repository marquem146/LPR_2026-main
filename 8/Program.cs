using System;
using System.Runtime.CompilerServices;
namespace programa1
{
    class exercicio1
    {
        public struct Produto
        {
            public float preco1, preco2, preco3;
            public string nome1, nome2, nome3;
            public int quant1, quant2 , quant3;
            public int codigo1, codigo2, codigo3;
        }
        public void Main(string []args)
        {
            Produto[] dados = new Produto[4];
            
            Console.WriteLine("digite os dados do produto 1: ");
            Console.WriteLine("nome: " );
            dados[0].nome1 = Console.ReadLine()!;
            Console.WriteLine("preco: " );
            dados[0].preco1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("codigo: " );
            dados[0].codigo1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("quantidade: " );
            dados[0].quant1 = int.Parse(Console.ReadLine()!);
           
            Console.WriteLine("digite os dados do produto 2: ");
            Console.WriteLine("nome: " );
            dados[1].nome2 = Console.ReadLine()!;
            Console.WriteLine("preco: " );
            dados[1].preco2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("codigo: " );
            dados[1].codigo2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("quantidade: " );
            dados[1].quant2 = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine("digite os dados do produto 3: ");
            Console.WriteLine("nome: " );
            dados[2].nome3 = Console.ReadLine()!;
            Console.WriteLine("preco: " );
            dados[2].preco3 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("codigo: " );
            dados[2].codigo3 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("quantidade: " );
            dados[2].quant3 = int.Parse(Console.ReadLine()!);
            
            int soma_quant(int q1,int q2,int q3)
            {
                return q1+q2+q3;
            }
            float soma_preco(float p1, float p2, float p3)
            {
                return p1+p2+p3;
            }
            int show1 = soma_quant(dados[0].quant1 , dados[1].quant2 , dados[2].quant3);
            float show2 = soma_preco(dados[0].preco1, dados[1].preco2 , dados[2].preco3);
            Console.WriteLine(" Soma da quatidade"+show1);
            Console.WriteLine("Soma do preco: " +show2);
        }

    }
}