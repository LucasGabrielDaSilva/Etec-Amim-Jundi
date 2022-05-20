#include <iostream>
using namespace std;

int main(){
    int valor[14];
    
    for(int i=0 ; i<14; i++)
    {
        cout<<"\n Entre com um numero:";
        cin>>valor[i];
    }
        cout <<"\n Vejamos o resultado do vetor\n";
    for (int t=0 ; t<14; t++) 
    {
        cout <<"["<<t<<"] Numero Digitado= "<<valor[t]<<"\n";
    }    
      
    system("PAUSE>null"); return 0;}
    
