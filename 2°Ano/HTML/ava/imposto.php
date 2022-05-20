 <!DOCTYPE html>
<html>
<head>
</head>
<title> Avaliação </title>
<body>
<?php
    echo"<p>Origem:<br> ";
    $Codigo = 69; 
   if ($Codigo > 1 && $Codigo <= 20)
    {
        echo "Imposto de 7%";
    }

    else if ($Codigo >=21 && $Codigo <=40)
    {
    echo "Imposto de 9%";
    }
	else if ($Codigo >=41 && $Codigo <=60)
    {
    echo "Imposto de 10%";
    }
	else if ($Codigo >=61 && $Codigo <=70)
    {
    echo "Imposto de 11%";
    }
    else if ($Codigo <= 0 )
    {
    echo "Produto não existe!";
    }
    else if ($Codigo > 71)
    {
    echo "Produto não Cadastrado!";
    }
?>
</body>
</html>
