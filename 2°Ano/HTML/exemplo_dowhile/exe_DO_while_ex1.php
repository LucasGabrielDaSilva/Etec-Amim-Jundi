<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="utf-8">
	</head>
<body bgcolor = "#48D1CC">
 <h1> <center>  Exemplo da Estrutura de Repetição do while  <p>  Números de 20 a 50 <p>
  <?php
   	$num = 20;
 		do
		{	
  			echo " $num <br> "; 
  			$num = $num + 1;
		} while ($num <= 50);
	?>
</body>
</html>