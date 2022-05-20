#include <stdio.h>
#include <stdlib.h>

main ()

{

    int  nasc, atual, idade, dias;
	char nome[20];
	
	printf("Informe seu nome: \n");
	scanf("%s" ,&nome);
	
	printf("Informe o ano atual: ");
	scanf("%d" ,&atual);
	
	printf("\nInforme o ano de nascimento: ");
	scanf("%d" ,&nasc);
	
	idade = atual - nasc ;
	
	dias = idade * 360;
	
	printf("\n %s voce tem: ", nome);
	printf("\nIdade:%d \nDias de vida: %d\n", idade, dias);	
	system("PAUSE");
		
}
