<!DOCTYPE html>
<html lang="pt-br">
<body bgcolor = "#48D1CC">
    <h1> <center> Salario <p>
    <?php
        $Codigo = 35; 

        if ($Codigo > 1 && $Codigo <= 10)
    {
        echo "Região Sul";
    }

    else if ($Codigo >= 11 && $Codigo < 30)
    {
    echo "Região Sudeste";
    }
    else if ($Codigo >= 31 && $Codigo < 50)
    {
    echo "Região Centro-Oeste";
    }
 else if ($Codigo >= 51 && $Codigo < 70)
    {
    echo "Região Nordeste";
	}
     else if ($Codigo >= 71 && $Codigo < 95)
    {
    echo "Região Norte";
    }
    else if ($Codigo <= 0)
    {
    echo "Produto não existe";
    }
    else if ($Codigo > 95)
    {
    echo "Produto não cadastrado";
    }

    ?>

</body>
</html>