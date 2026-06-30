#include <iostream>
using namespace std;
int main()
{ 
    int resultado [3][3] = {};
    int matrizA [3][3];
    matrizA [0][0] = 2;
    matrizA [1][0] = 4;
    matrizA [2][0] = 6;

    matrizA [0][1] = 6;
    matrizA [1][1] = 8;
    matrizA [2][1] = 2;

    matrizA [0][2] = 6;
    matrizA [1][2] = 6;
    matrizA [2][2] = 6;
    
    int matrizB [3][3];
    matrizB [0][0] = 2;
    matrizB [1][0] = 4;
    matrizB [2][0] = 6;

    matrizB [0][1] = 6;
    matrizB [1][1] = 8;
    matrizB [2][1] = 2;

    matrizB [0][2] = 6;
    matrizB [1][2] = 6;
    matrizB [2][2] = 6;
    for(int i = 0; i < 3; i++ )
    {
        for(int j = 0; j < 3; j++)
        {
            for(int k = 0; k < 3; k++)
            {
                resultado[i][k] = matrizA [i][k] * matrizB [k][j];
            }
        }
    }
    cout << "Matriz resultante: \n";
    for(int i = 0; i < 3; i++ )
    {
     for (int j = 0; j< 3; j++)
     {
        cout << resultado [i][j] << "\t";
     }
     cout <<"\n";
    } 
}