using System;
using System.Runtime.CompilerServices;
namespace programa2
{
    class exercicio2
    {
        public struct Livros
        {
            public string ti1,ti2,ti3;
            public string aut1,aut2,aut3;
            public int anopubli1,anopubli2,anopubli3;
            public int numpa1,numpa2,numpa3;
            public float preco1,preco2,preco3;
        }
        public void Main(string []args)
        {
            Livros[] dadoL = new Livros[5];
            Console.WriteLine("digite os seguintes dados do livro1: ");
            dadoL[0].ti1 = Console.ReadLine()!;
            Console.WriteLine("Autor: ");
            dadoL[0].aut1 = Console.ReadLine()!;
            Console.WriteLine("Ano de publicacao: ");
            dadoL[0].anopubli1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Numeros de paginas: ");
            dadoL[0].numpa1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ano de publicacao: ");
            dadoL[0].preco1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("digite os seguintes dados do livro2: ");
            dadoL[1].ti2 = Console.ReadLine()!;
            Console.WriteLine("Autor: ");
            dadoL[1].aut2 = Console.ReadLine()!;
            Console.WriteLine("Ano de publicacao: ");
            dadoL[1].anopubli2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Numeros de paginas: ");
            dadoL[1].numpa2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ano de publicacao: ");
            dadoL[1].preco2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("digite os seguintes dados do livro1: ");
            dadoL[2].ti3 = Console.ReadLine()!;
            Console.WriteLine("Autor: ");
            dadoL[2].aut3 = Console.ReadLine()!;
            Console.WriteLine("Ano de publicacao: ");
            dadoL[2].anopubli3 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Numeros de paginas: ");
            dadoL[2].numpa3 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ano de publicacao: ");
            dadoL[2].preco3 = float.Parse(Console.ReadLine()!);

            float preco_total(float p1,float p2,float p3)
            {
                return p1+p2+p3;
            }
          int media_pag(int n1, int n2, int n3)
            {
                return (n1+n2+n3/2);
            }
            float pt = preco_total(dadoL[0].preco1, dadoL[1].preco2, dadoL[2].preco3);
            int mp = media_pag(dadoL[0].numpa1, dadoL[1].numpa2, dadoL[2].numpa3);
            Console.WriteLine("Preco total: "+ pt);
            Console.WriteLine("Media das paginas: "+ mp);
        }

    }
}