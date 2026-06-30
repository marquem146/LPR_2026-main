#include <iostream>
#include <string>
using namespace std;
int main()
{
    void distancia(void);
    string c1,c2;
    c1 = "1";
    c2 = "2";
    string usuario;
    int matriz [4][4];
    matriz [0][0] = 0; //vitoria
    matriz [0][1] = 524; //vitoria para BH*
    matriz [0][2] = 521; //vitoria para RJ*
    matriz [0][3] = 882; //vitoria para SP*

    matriz[1][0] = 524; //BH para vitoria*
    matriz[1][1] = 0; //BH
    matriz[1][2] = 434; //BH para RJ*
    matriz[1][3] = 586; //BH para SP*

    matriz[2][0] = 521; // RJ para vitoria*
    matriz[2][1] = 434;// RJ para BH*
    matriz[2][2] = 0; // RJ 
    matriz[2][3] = 429; // RJ para SP*

    matriz[3][0]= 882; // SP para vitoria*
    matriz[3][1] = 586; // SP para BH*
    matriz[3][2] = 429; // SP para RJ*
    matriz[3][3] = 0; // SP

    while(c1 != c2)
    {
        cout << "digite a cidade origem:\n";
        cin >> c1; 
         cout << "digite a cidade destino:\n";
         cin >> c2;
        if(c1 == c2)
        {
          cout << "voce ja saiu" << endl;
        }
         else
         {
           cout <<  distancia;
         }
    }

 cout << "me fale qual seu destino :" ;
 cin >> usuario;
 void distancia(string c1,string c2);
 {

       if( usuario == "vitoria para BH" && usuario == "BH para vitoria")
 {
  cout <<" A distancia de uma para outra é de: "<< matriz[0][1] << "km" << endl;
 }
 else if( usuario == "vitoria para RJ" && usuario == " RJ para vitoria")
 {
    cout <<" A distancia de uma para outra é de: "<< matriz[0][2] << "km" << endl;
 }
else if(usuario == "vitoria para SP" && usuario == "SP para vitoria")
 {
    cout <<" A distancia de uma para outra é de: "<< matriz[0][3] << "km" << endl;
 }
else if(usuario == "BH  para RJ" &&  usuario == "RJ para BH")
 {
  cout <<" A distancia de uma para outra é de: "<< matriz[2][1] << "km" << endl;
 }
 else if(usuario == " BH para SP" && usuario == " SP para BH")
 {
    cout <<" A distancia de uma para outra é de: "<< matriz[3][1] << "km" << endl;
 }
 else if( usuario == "RJ para SP" && usuario == "SP para RJ")
 {
    cout <<" A distancia de uma para outra é de: "<< matriz[3][2] << "km" << endl;
 }
 else
 {
    cout << " não tem distancia definida";
 }
 }
}
