#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

main()

{
	int quant;
	float valor, v1;
	
	printf("Quantidade areecadada das rifas venndidas?\n");
	scanf("%d", &quant);
	
	printf("Qual o valor das rifas vendidas?\n");
	scanf("%f", &valor);
	
	v1= quant*valor;
	
	if (v1 >2000);
	{
		printf("\nValor alto:%f", v1);
	}
	
	system("PAUSE");;
	
}
