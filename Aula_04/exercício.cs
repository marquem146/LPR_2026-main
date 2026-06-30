using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("digite seu número para saber se é par ou impar: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0)
        {
            Console.WriteLine("o seu número é par");
        }
        else if(num % 2 == 1)
        {
            Console.WriteLine("o seu número é impar");
        }
    }
}