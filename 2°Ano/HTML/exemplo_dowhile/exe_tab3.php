<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="utf-8">
	</head>
<body bgcolor = "#48D1CC">
 <h1> <center>  Exemplo da Estrutura de Repetição while  <p>  Tabuada do 4 <p>
  <?php
   	$num = 1;
 		 do
		{	
  			$tab = $num * 4;
  			echo " 4  *  $num =  $tab <br> "; 
  			$num = $num  + 1;
  			
		} while ($num <= 10);
	?>
</body>
</html>