<!DOCTYPE html>
<html lang="pt-br">
	<head>
		<meta charset="utf-8">
	</head>
<body bgcolor = "#48D1CC">
 <h1> <center> Estrutura Condicional <p>  
  <?php
   	$idade = 66;
 		if ($idade >= 0 &&  $idade <= 12)	
		{	
  			echo " Idade = $idade, criança !";
		}
 		else if ($idade >= 13 && $idade <= 18)	
		{	
  			echo " Idade = $idade, adolescente !";
		}
		else if ($idade >= 19 && $idade < 65)	
		{	
  			echo " Idade = $idade, Adulto";
		}
		else if ($idade >= 65)	
		{	
  			echo " Idade = $idade, Idoso";
		}
		else if ($idade < 0)	
		{	
  			echo " Idade = $idade, Valor inválido!!!" ;
		}
	?>
</body>
</html>