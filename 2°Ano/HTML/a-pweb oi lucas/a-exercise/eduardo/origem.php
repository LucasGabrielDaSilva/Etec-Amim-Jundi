<!DOCTYPE html>
<html lang = "pt-br">
<head>
<fonte size = Arial>
<body bgcolor="Lime">	
<h1><center> Sálario Funcionário <p>
	
	<?php
	$codigo = 100;
	if ($codigo >=1 && $codigo <=10)
	{
		echo "Região Sul.";
	}
	if ($codigo >=11 && $codigo <=30) 
	{
        echo "Região Sudeste.";
	}
    if ($codigo >=31 && $codigo <=50)
	{
		echo "Região Centro-Oeste.";
	}
	if ($codigo >=51 && $codigo <=70)
	{
		echo "Região Nordeste.";
	}
	if ($codigo >=71 && $codigo <=95)
	{
		echo "Região Norte.";
	}
	if ($codigo <=0)
	{
		echo "Produto Não Existe.";
	}
	else if ($codigo >95)
	{
		echo "Produto Não Cadastrado.";
	}
    ?>
</body>
</html>
</head>





