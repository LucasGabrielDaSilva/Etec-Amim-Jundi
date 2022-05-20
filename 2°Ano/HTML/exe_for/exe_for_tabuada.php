<!DOCTYPE html>
<html lang = "pt-br">
	<head>
		<meta charset = "utf-8">
	</head>
<body bgcolor = "#48D1CC">
	<center> <h1> Exemplo de Estrutura de Repetição for <p> Números de 1 a 10 <p>
   <?php
   for ($num = 0; $num <= 10;
   $num++)
   {
	   $tab = $num * 3;
	   echo "$num * 3 = $tab <br>";
   }
   ?>
</body>
</html>   