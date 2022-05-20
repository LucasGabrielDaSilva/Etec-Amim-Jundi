#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

main( )

{

    setlocale(LC_ALL, "Portuguese");

    int n1, n2;
    
    printf("\nInforme o primeiro valor:\n");
    scanf("%d", &n1);
    
    printf("\nInforme o segundo valor:\n");
    scanf("%d",&n2);
	 
 if(n1>n2)
    {
	    printf("\n%d é maior que %d\n", n1, n2);
	}
	
else (n2>n1); 
	{
		printf("\n %d é maior que %d\n", n2, n1);
	}
	
system("PAUSE");

}
