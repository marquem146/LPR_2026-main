class exercicio1
{
    static void Main(string[] args)
    {
      int[] numeros =  new int[5];
     numeros = new int[5] { 1, 2, 3, 4, 5};
     int[] pares =  new int[5];
     int[] impares = new int[5];
    for(int i = 0; i<6; i++)
     {
    System.Console.WriteLine(numeros[i]);
    if(numeros[i] % 2 == 0)
    {
        System.Console.WriteLine(numeros[i]);
        pares = [numeros[i]];
    }
    if(numeros[i] % 2 == 1)
    {
        System.Console.WriteLine(numeros[i]);
        impares = [numeros[i]];

    }
    }
     }
    }
