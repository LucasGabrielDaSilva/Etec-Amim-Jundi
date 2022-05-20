#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()

{
	
	printf(setlocale(LC_ALL,""));
	system("cls");
	
	int perda = 50;
	printf("O valor armazenado é: %d \n", perda);
	
	system("PAUSE");
	
	int NUM1, NUM2, NUM3, NUM4, mult1, mult2,  mult3, mult4;
	
	printf("Informe o primeiro numero ");
	scanf("%d", &NUM1);
	
	printf("\n Informe o segundo numero ");
	scanf("%d", &NUM2);
	
	printf("\n Informe o terceiro numero ");
	scanf("%d", &NUM3);
	
	printf("\n Informe o quarto numero ");
	scanf("%d", &NUM4);
	
	mult1 =NUM1*3;
	
	mult2 = NUM2*3;
	
	mult3 = NUM3*3;
	
	mult4 = NUM4*3;
	
	printf("A multiplicação do primeiro valor é: %d \n", mult1);
	
	printf("A multiplicação do segundo valor é: %d \n", mult2);
	
	printf("A multiplicação do terceiro valor é: %d \n", mult3);
	
	printf("A multiplicação do quarto valor é: %d \n", mult4);
	
	system("PAUSE");
	
}
