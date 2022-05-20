<!DOCTYPE html>
<html>
<h1> <center> Preço do Produto <p></head>
<body>
<?php

     $preco = 50;
     

if ($preco >= 10 && $preco <= 50)
{
	echo $aumento = $preco * 1.10;
}

else if ($preco >= 51 && $preco <= 100)
{
	echo $aumento = $preco * 1.08;
}

else if ($preco > 100)
{
	echo %aumento = $preco * 1.06;
}

else if ($preco < 10)
{
	echo "Valor não cadastrato";
}

?>
</body>
</html>