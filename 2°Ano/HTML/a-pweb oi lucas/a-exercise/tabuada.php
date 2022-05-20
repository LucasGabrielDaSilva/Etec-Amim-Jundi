<!DOCTYPE html>
<html>
<head lang="pt-br">
	<meta charset="utf-8">
	<title>Tabuada</title>
</head>
<body>
	<h1> <center> Tabuada <p> 
		<?php
		$num = 1;
		$valor = 9;

		while ($num <= 10) 
		{
			$tab = $num * $valor;
			echo "$valor * $num = $tab <br>";
            $num = $num + 1;
		}
		?>
</body>
</html>