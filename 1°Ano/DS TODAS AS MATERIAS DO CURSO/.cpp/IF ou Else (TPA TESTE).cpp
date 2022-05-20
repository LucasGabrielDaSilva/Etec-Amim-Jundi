#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

main( )

{

    setlocale(LC_ALL, "Portuguese");

    float salario;
    
    printf("\nInforme seu salario: \n");
    scanf("%f", &salario);
    
    if(salario <774)
    
	{
    
		printf("\nSalario Invalido\n");
	
	}
	
	else if(salario<1000)
	
	{

		salario = salario + (0.4*salario);
		printf("\nSeu salario atual é: %4.2f\n", salario);

	}

	else if(salario<2000)

	{

		salario = salario + (0.3*salario);
		printf("\nSeu salario atual é: %4.2f\n", salario);

	}
	
		else if(salario<3000)
	{

		salario = salario +(0.1*salario);
		printf("\nSeu salario atual é: %4.2f\n", salario);
		
	}

	else

	{
		salario = salario +(0.88*salario);
		printf("\nSeu salario atual é: %4.2f\n", salario);
	}

    system("PAUSE");

}
