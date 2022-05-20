<!DOCTYPE html>
<html lang = "pt-br">
<head>
<font size="Arial">
<body bgcolor="Lime">
<title>Exercício 3.</title>
<h1><center> Salário Funcionário <p>

	<?php  
	$codigo = 46;


	if ($codigo >= 1 && $codigo <= 10)
	{
		echo "Região Sul.";	
	}
	if ($codigo >= 11 && $codigo <= 30)
	{
		echo "Região Sudeste.";	
	}
	if ($codigo >= 31 && $codigo <= 50)
	{
		echo "Região Centro-Oeste.";	
	}
	if ($codigo >= 51 && $codigo <= 70)
	{
		echo "Região Nordeste.";	
	}
	if ($codigo >= 71 && $codigo <= 95)
	{
		echo "Região Norte.";	
	}
	else if ($codigo <= 0 && $codigo > 95)
	{
		echo "Produto não cadastrado/existente.";	
	}

	?>
</head>
</body>
</html>
