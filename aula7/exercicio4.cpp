#include <iostream>
using namespace std;
int main()
{
     int matriz [3][3];
   matriz [0][0] = 12;
   matriz[0][1] = 15;
   matriz[0][2] = 17;

   matriz[1][0] = 22;
   matriz[1][1] = 25;
   matriz[1][2] = 27;

   matriz[2][0] = 32;
   matriz[2][1] = 35;
   matriz[2][2] = 37;

   for(int i = 0; i < 3; i++)
   {
    for(int j = 0; j < 3; j++)
    {
        cout << matriz[i][j] << ",";
    }
   }
   int soma1 = (matriz[0][0]+ matriz[0][1] + matriz[0][2]);
     int soma2 = (matriz[1][0]+ matriz[1][1] + matriz[1][2]);
     int soma3 = (matriz[2][0]+ matriz[2][1] + matriz[2][2]);

     int somaT= (soma1 + soma2 + soma3);

     cout<<"Soma: "<<somaT<< endl;
}