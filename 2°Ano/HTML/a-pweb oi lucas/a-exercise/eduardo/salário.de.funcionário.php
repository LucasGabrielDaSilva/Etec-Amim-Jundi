<!DOCTYPE html>
<html lang = "pt-br">
<head>
<fonte size = Arial>
<body bgcolor="Lime">	
<h1><center> Sálario Funcionário <p>
	
	<?php
	$salario = 5000;
	if ($salario >=5000)
	{
		echo "$salario = Aumento de 8%";
    }
	if ($salario >=2000 && $salario <5000)
	{
		echo "$salario = Aumento de 10%";
	}
	if ($salario >=800 && $salario <2000)
    {
    	echo "$salario = Aumento de 12%";
    }
    else if ($salario <800)
    {
    	echo "$salario = Valor inválido!";
    }
	?>
</head>
</body>
</html>