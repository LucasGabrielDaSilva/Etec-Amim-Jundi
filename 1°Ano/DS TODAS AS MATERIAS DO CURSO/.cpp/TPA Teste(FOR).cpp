#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

main( )
{

  printf(setlocale(LC_ALL,""));
  
  for (int N=1; N <=50; N++)
  
  {
  	
  	printf("\n%d \n",N);
  	
  }
  scanf("PAUSE");
  
}
