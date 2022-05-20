#include <stdlib.h>
#include <stdio.h>
#include <locale.h>



main( )
{

printf(setlocale(LC_ALL,""));
system("cls");

 char p1[20], p2[20], p3[20], p4[20], p5[20];
 float v1, v2, v3, v4, v5, total;
 
 printf("Digite o nome do produto: ");
 scanf("%s", &p1);
 
 printf("\nDigite o valor do produto: ");
 scanf("%f", &v1);
 
 printf("\nDigite o nome do produto: ");
 scanf("%s", &p2);
 
 printf("\nDigite o valor do produto: ");
 scanf("%f", &v2);
 
 printf("\nDigite o nome do produto: ");
 scanf("%s", &p3);
 
 printf("\nDigite o valor do produto: ");
 scanf("%f", &v3);
 
 printf("\nDigite o nome do produto: ");
 scanf("%s", &p4);
 
 printf("\nDigite o valor do produto: ");
 scanf("%f", &v4);
 
 printf("\nDigite o nome do produto: ");
 scanf("%s", &p5);
 
 printf("\nDigite o valor do produto: ");
 scanf("%f", &v5);
 
 
 total = v1+v2+v3+v4+v5;
 
 printf("\n-------LISTA DE COMPRAS--------");
 printf("\nProduto: %s - Valor: R$ %4.2f", p1, v1);
 printf("\nProduto: %s - Valor: R$ %4.2f", p2, v2);
 printf("\nProduto: %s - Valor: R$ %4.2f", p3, v3);
 printf("\nProduto: %s - Valor: R$ %4.2f", p4, v4);
 printf("\nProduto: %s - Valor: R$ %4.2f", p5, v5);
 
 printf("\nTOTAL DA COMPRA: R$ %4.2f", total);
system("PAUSE");



}
