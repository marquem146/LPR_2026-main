// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        int contador = 0;
        int somapares = 0;
        int quantpares = 0;

        Console.WriteLine("digite a quantidade de numeros:");
        int totalNumeros = Convert.ToInt32(Console.ReadLine());

        while(contador < totalNumeros)
        {
            Console.WriteLine($"digite o {contador + 1} numero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                somapares += num;
                quantpares++;
            }
            contador++;
        }

        if(quantpares > 0)
        {
            float media = (float)somapares / quantpares;
            Console.WriteLine($"Números pares encontrados: {quantpares}");
            Console.WriteLine($"A média aritmética dos pares é: {media:F2}");
        }
        else
        {
            Console.WriteLine("nenhum numero par encontrado");
        }
    }
}
