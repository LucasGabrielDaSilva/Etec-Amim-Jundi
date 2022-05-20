<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="utf-8">
	</head>
<body bgcolor = "#48D1CC">
 <h1> <center>  Exemplo da Estrutura de Repetição while  <p>  Tabuada do 3 <p>
  <?php
   	$num = 1;
 		while ($num <= 10)
		{	
  			$tab = $num * 3;
  			echo " 3  *  $num =  $tab <br> "; 
  			$num = $num  + 1;
  			
		}
	?>
</body>
</html>