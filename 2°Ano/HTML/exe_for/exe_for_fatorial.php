<!DOCTYPE html>
<html lang = "pt-br">
	<head>
		<meta charset = "utf-8">
	</head>
<body bgcolor = "#48D1CC">
	<center> <h1> Exemplo de Estrutura de Repetição for <p> 
   <?php
   $fat = 1;
   for ($num = 1; $num <= 4; $num++)
   {
	   $fat = $fat * $num;
	   echo "$fat <br>";
   }
   echo "<br> Fatorial de 4: $fat <br>";
   ?>
</body>
</html>   