#include <iostream>
using namespace std;

int main ( ) {
int valor[20]; 
for(int i=0 ;i<20; i++) 
{
cout <<"\nInforme a idade do aluno: ";cin >> valor [ i ];
}
cout << "\nVejamos o resultado do vetor \n";
for(int t=0; t<20; t++)
{
cout << "Idade dos alunos ["<< t << "] = " << valor[t]<< "\n";
}
system("PAUSE > null");
return 0;   
}
