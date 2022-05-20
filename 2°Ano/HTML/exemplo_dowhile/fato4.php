<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="utf-8">
	</head>
<body bgcolor = "#48D1CC">
 <h1> <center>  Fatorial do 4 : <p>
  <?php
   	$fat = 1;
   	$cont = 4;
 		do
		{	
  			$fat = $cont * $fat;
  			echo "  $fat <br> "; 
  			$cont = $cont - 1;
		} while ($cont >= 1);

		echo " Fatorial de 4:  $fat <br> "; 
	?>
</body>
</html>