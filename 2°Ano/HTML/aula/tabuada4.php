<!DOCTYPE html>
<html>
<head lang="pt-br">
	<meta charset="utf-8">
	<title>Tabuada</title>
</head>
<body>
	<h1> <center> Tabuada <p> 
		<?php
		$num = 1;
	     $x = 4;

		do
		{
			$tab = $x * $num;
			echo "$x * $num = $tab <br>";
            $num = $num + 1;
		}
		while ($num <= 10);
		?>
</body>
</html>