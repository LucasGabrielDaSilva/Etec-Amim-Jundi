<!DOCTYPE html>
<html lang="pt-br">
<body bgcolor = "#48D1CC">
    <h1> <center> Salario <p>
    <?php
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

	?>

</body>
</html>