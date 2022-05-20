#include <stdio.h>
#include <stdlib.h>
main()
{
int resp = 1;   
 while (resp == 1)
 {
  int n , tab , x=1,     
   printf("Digite um numero para calcular a tabuada:%d");
   scanf("%d",&n); 
   while (x <= 10)
  {
	tab = x * n;
	printf("%d * %d = %d \n", n, x, tab);
	x++;
  }
	 	
	printf("\nDeseja continuar? \nDigite 1(sim) ou 2(nao): ");
    scanf( "%d",&resp);
    system("CLS");
}	
printf("\n");    	
system("PAUSE");

}
