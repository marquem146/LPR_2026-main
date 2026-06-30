using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

    namespace exercicio2
{
    class Program
    {
public static void Main(string[] args)
      {
int[] numeros = new int[10];
numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};
bool[] encontrado = new bool[10];

System.Console.WriteLine("digite um numero que voce gostaria de achar: ");
int achar = System.Convert.ToInt32(System.Console.ReadLine());
 
for(int i =0; i <= numeros.Length ;i++)
{
                
     switch(achar)
    {
        case 1:
        encontrado[0] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[0]);
        break;
        
        case 2:
        encontrado[1] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[1]);
        break;
        
        case 3:
        encontrado[2] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[2]);
        break;

        case 4:
        encontrado[3] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[3]);
        break;
        
        case 5:
        encontrado[4] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[4]);
        break;
        
        case 6:
        encontrado[5] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[5]);
        break;

         case 7:
        encontrado[6] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[6]);
        break;
        
        case 8:
        encontrado[7] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[7]);
        break;
        
        case 9:
        encontrado[8] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui:" + numeros[8]);
        break;

        case 10:
        encontrado[9] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui: " + numeros[9]);
        break;

        case 11:
        encontrado[10] = true;
        System.Console.WriteLine("posição: "+ i);
        System.Console.WriteLine("o numero esta aqui: " + numeros[10]);
        break;

        default:
        System.Console.WriteLine("posição nao encontrada" );
        System.Console.WriteLine("nenhum numero foi achado");
        break;

}
         }
    
        }
    }
}
