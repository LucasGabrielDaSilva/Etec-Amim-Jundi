<!DOCTYPE html>
<html lang = "pt-br">
	<head>
	<meta charset="utf-8">
	</head>
	<body bgcolor="blue">

<h1> <center> Estrutura Condicional <p>

<?php
$idade = 2;
if ($idade >= 0 && $idade <= 12)
{
	echo "criança";
}
else if ($idade >= 13 && $idade <= 18)
{
	echo "adolescente";
}
else if ($idade >= 19)
{
	echo "adulto";
}

?>
</body>
</html>