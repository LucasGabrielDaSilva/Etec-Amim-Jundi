<!DOCTYPE html>
	<html lang="pt-br">
	<head>
		<title> PHP Exercise -by stour. </title>
		<h1> Consumo de água de uma residência. <p> </h1>
	</head>
	<body>
		<?php  
		$consumo = 13;
		if ($consumo <= 10)
		{
			echo "$consumo = R$20,64.";
		}
			else if ($consumo > 10)
		{
			echo "$consumo = A sua tarifa deverá ser calculada.";
		}

?>

	</body>
	</html>
