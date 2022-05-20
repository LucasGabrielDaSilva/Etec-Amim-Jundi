<!DOCTYPE HTML> 
<html lang = "pt-br">
	<head>
	<meta charset="utf-8">
	</head>

<body bgcolor = "#00FA9A">
<h1> <center> Estrutura Condicional <p>
	

	<?php
	$produto = 160;
	if ($produto >= 100)
	

		{
		echo "Preço = $produto, Aumento de 6%!";
		}

		else if ($produto < 100)
		
		{

			echo "Preço = $produto, Aumento de 8 %!";			
		}
	?>
</body>
</html>