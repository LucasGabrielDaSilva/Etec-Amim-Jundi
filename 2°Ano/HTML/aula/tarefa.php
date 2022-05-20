<!DOCTYPE html>
<html>
<head>
<body>
<?php
 $consumo = 100;
 
 if ($consumo <= 10)
 {
	 echo "Tarifa mínima de R$ 20,64";
 }
 else if ($consumo >10)
 {
	 echo "A sua tarifa deverá ser calculada"; 
 }
 $salario= 1200;
         $Agua = 30; 

        if ($Agua <= 10)
    {
        echo "Tarifa minima de R$20,64";
    }

    else if ($Agua > 10)
    {
    echo "A sua tarifa deverá ser calculada";
    }
	
    echo"<p>Salario:";	
    $Salario = 1500; 

        if ($Salario >= 5000)
    {
        echo "Aumento de 8 %";
    }

    else if ($Salario >= 2000 && $Salario < 5000)
    {
    echo "Aumento de 10 %";
    }
    else if ($Salario >= 800 && $Salario < 2000)
    {
    echo "Aumento de 12 %";
    }
    else if ($Salario < 800)
    {
    echo "Valor inválido!";
    }

    echo"<p>Origem: ";
    $Codigo = 40; 

        if ($Codigo > 1 && $Codigo <= 10)
    {
        echo "Região Sul";
    }

    else if ($Codigo >= 11 && $Codigo < 30)
    {
    echo "Região Sudeste";
    }
    else if ($Codigo >= 31 && $Codigo < 50)
    {
    echo "Região Centro-Oeste";
    }
    else if ($Codigo >= 51 && $Codigo < 70)
    {
    echo "Região Nordeste";
	}
     else if ($Codigo >= 71 && $Codigo < 95)
    {
    echo "Região Norte";
    }
    else if ($Codigo <= 0)
    {
    echo "Produto não existe";
    }
    else if ($Codigo > 95)
    {
    echo "Produto não cadastrado";
    }
	
echo"<p>Reajuste Salarial: ";
$Salario= 500;
	
	if ($Salario >= 400 && $Salario < 600)
	{
		echo $Reajuste = $Salario * 1.18;
	}
	else if ($Salario >=600 && $Salario <800)
	{
		echo $Reajuste = $Salario * 1.16;
	}
	else if ($Salario >=800 && $Salario <1200)
	{
		echo $Reajuste = $Salario * 1.15;
	}
	else if ($Salario >=1200)
	{
		echo $Reajuste = $Salario * 1.12;
	}
	else if ($Codigo < 400)
    {
    echo "Valor Inválido!";
    }

echo"<p>Calculo de peso Ideal:";
$nome = "Lucas"; 
$sexo = 1;
$sexo = 2;
$peso = 65;
$altura = 1.65;
$result =  $peso / $altura * $altura ; 
if ($sexo = 1)
{
	
 echo"Seu imc é: $result";

}
else if ($sexo =2)
{
	echo"Seu imc é: $result";
}
    
?>
</head>
</body>
<html>
